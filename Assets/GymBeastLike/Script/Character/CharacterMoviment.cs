using UnityEngine;
namespace GymBeastLike
{
    public class CharacterMoviment : MonoBehaviour
    {
        private CharacterController charactercontroller;
        private float speed = 5.0f;
        private GameObject character;
        private bool moving;
        private string animationname = "running";
        
        void Awake()
        {
            character = transform.Find("Character").gameObject;
            charactercontroller = GetComponent<CharacterController>();
            if (charactercontroller == null)
            {
                charactercontroller = gameObject.AddComponent(typeof(CharacterController)) as CharacterController;
            }
            moving = false;
        }

        void Update()
        {
            if (CharacterManager.Instance.GetControlable())
            {
                float moveHorizontal = Input.GetAxis("Horizontal");
                float moveVertical = Input.GetAxis("Vertical");

                Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;
                if (move != Vector3.zero)
                {
                    if (!moving)
                    {
                        moving = true;
                        CharacterManager.Instance.GetAnimator().PlayAnimationByParameter(animationname, true);
                    }
                    
                    character.transform.rotation = Quaternion.LookRotation(move, Vector3.up);
                }
                else
                {
                    moving = false;
                    CharacterManager.Instance.GetAnimator().PlayAnimationByParameter(animationname, false);
                }
                charactercontroller.Move(move * speed * Time.deltaTime);
            }
        }


    }
}
