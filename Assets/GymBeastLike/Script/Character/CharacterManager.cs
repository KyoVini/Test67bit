using UnityEngine;
namespace GymBeastLike
{
    public class CharacterManager : Singleton<CharacterManager>
    {
        private ICameraControl playercamera;
        private IAnimationController animator;
        private Vector3[] pointscamera;
        private bool controlable;
        private GameObject character;
        private CharacterHitbox hitbox;

        protected override void Awake()
        {
            base.Awake();

            //Scripts and components
            playercamera = transform.Find("CharCam").gameObject.GetComponent<CameraControl>();
           
             //Variables
             pointscamera = new Vector3[3];
            for (int i = 1; i <= pointscamera.Length; i++)
            {
                pointscamera[i-1] = transform.Find("pointCamera" + i).transform.position;
            }
            controlable = false;

            //Objects
            character = transform.Find("Character").gameObject;
            animator = character.transform.GetComponent<CharacterAnimationControl>();
            hitbox = character.transform.Find("hitbox").GetComponent<CharacterHitbox>();
           Debug.Log(animator);
        }
        public ICameraControl GetCamera() => playercamera;
        public GameObject GetPlayer() => character;
        public Vector3[] GetCamPositions => pointscamera;
        public bool GetControlable() => controlable;
        public CharacterHitbox GetHitbox() => hitbox;
        public IAnimationController GetAnimator() => animator;
        public void SetControlable(bool _controlable)
        {
            controlable = _controlable;
        }

        private void Start()
        {
            SetControlable(true);
        }

    }
}
