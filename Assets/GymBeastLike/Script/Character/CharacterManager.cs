using UnityEngine;
namespace GymBeastLike
{
    public class CharacterManager : Singleton<CharacterManager>
    {
        private ICameraControl playercamera;
        private IAnimationController animator;
        private ICharacterHitbox hitbox;
        private IStackUP stackup;
        private ACharacterMoviment charactermoviment;
        private IMoveControl stackmoviment;
        private Vector3[] pointscamera;
        private bool controlable;
        private GameObject character;
        private ICharacterChangeSkin changeskin;
        
        protected override void Awake()
        {
            base.Awake();

            //Scripts and components
            playercamera = transform.Find("CharCam").transform.GetComponent<CameraControl>();
           
             //Variables
             pointscamera = new Vector3[3];
            for (int i = 1; i <= pointscamera.Length; i++)
            {
                pointscamera[i-1] = transform.Find("pointCamera" + i).transform.localPosition;
            }
            controlable = false;

            //Objects
            character = transform.Find("Character").gameObject; 
            animator = character.transform.GetComponent<CharacterAnimationControl>();
            hitbox = character.transform.Find("hitbox").GetComponent<CharacterHitbox>();
            stackup = transform.Find("StackUpEnemies").transform.GetComponent<StackUP>();
            stackmoviment = transform.Find("StackUpEnemies").transform.GetComponent<StackUPMoviment>();
            charactermoviment = GetComponent<ACharacterMoviment>();
            changeskin = character.transform.GetComponent<CharacterChangeSkin>();
        }
        public ICameraControl GetCamera() => playercamera;
        public GameObject GetPlayer() => character;
        public Vector3[] GetCamPositions => pointscamera;
        public bool GetControlable() => controlable;
        public ICharacterHitbox GetHitbox() => hitbox;
        public IAnimationController GetAnimator() => animator;
        public IStackUP GetStack() => stackup;
        public IMoveControl GetCharacterMovement() => charactermoviment;
        public IMoveControl GetStackMovemet() => stackmoviment;
        public ICharacterChangeSkin GetChangeSkin() => changeskin;
        public void SetControlable(bool _controlable){controlable = _controlable;}
        public bool IsMoving() {return charactermoviment.IsMoving();}
        public void CamVerifyPosition()
        {
            int postion1 = 3;
            int postion2 = 5;

            int stackobjects = stackup.GetStackedObjects().Count;

            if (stackobjects < postion1)
            {
                playercamera.SetPositionCamera(pointscamera[0]);
            }
            if (stackobjects == postion1 && stackobjects < postion2)
            {
                playercamera.SetPositionCamera(pointscamera[1]);
            }
            if(stackobjects >= postion2)
            {
                playercamera.SetPositionCamera(pointscamera[2]);
            }
        }
        public bool GetCarringMaxEnemies()
        {
            int currentenemies = stackup.GetStackedObjects().Count;
            int maxenemies= GamePlayData.Instance.GetEnemiesCanCarry();
            if(currentenemies >= maxenemies)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
