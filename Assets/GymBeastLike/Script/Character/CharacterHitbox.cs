using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class CharacterHitbox : MonoBehaviour
    {
        [SerializeField] private KeyCode punch = KeyCode.Mouse0;
        [SerializeField] private float delaypunch;
        private bool ispunchable = true;
        private string animationname = "punch";
        private List<GameObject> collidingEnemies = new List<GameObject>();

        private void Start()
        {
            ispunchable = true;
            delaypunch = 0.6f;
        }

        private void OnTriggerEnter(Collider other)
        {
            collidingEnemies.Add(other.gameObject);
        }
        private void OnTriggerExit(Collider other)
        {
            collidingEnemies.Remove(other.gameObject);
        }

        void Update()
        {
            if (CharacterManager.Instance.GetControlable())
            {
                if (Input.GetKeyDown(punch) && ispunchable)
                {
                    CharacterManager.Instance.GetAnimator().PlayAnimationByParameter(animationname, true);
                    ispunchable = false;
                    HitEnemy();
                    Invoke(nameof(DelayPunch), delaypunch);
                    Debug.Log("punch");
                }
            }
        }

        private void DelayPunch()
        {
            ispunchable = true;
            CharacterManager.Instance.GetAnimator().PlayAnimationByParameter(animationname, false);
        }
        private void HitEnemy()
        {
            if(collidingEnemies.Count > 0)
            {
                Debug.Log("Bateu");
            }
            else
            {
                Debug.Log("Errou");
            }
        }
    }
}
