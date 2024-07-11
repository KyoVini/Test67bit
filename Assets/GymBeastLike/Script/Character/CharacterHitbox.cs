using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class CharacterHitbox : MonoBehaviour , ICharacterHitbox
    {
        [SerializeField] private KeyCode punch;
        [SerializeField] private float delaypunch;
        private bool ispunchable;
        private string animationname;
        private List<GameObject> collidingEnemies;

        public List<GameObject> GetEnemiesHitted() => collidingEnemies;

        private void Awake()
        {
            collidingEnemies = new List<GameObject>();
            punch = KeyCode.Mouse0;
            ispunchable = true;
            animationname = "punch";
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
                GameManager.Instance.PlayerHit();
            }
        }

        public void CleanObject(GameObject objtoclean)
        {
            if (collidingEnemies.Contains(objtoclean))
            {
                collidingEnemies.Remove(objtoclean);
            }
        }
    }
}
