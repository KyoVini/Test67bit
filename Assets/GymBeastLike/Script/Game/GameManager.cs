using UnityEngine;
namespace GymBeastLike
{
    public class GameManager : Singleton<GameManager>
    {
        private Notifier playerhit;
        // Start is called before the first frame update
        protected override void Awake()
        {
            base.Awake();
            playerhit = new Notifier();
        }
        public Notifier GetPlayerHit() => playerhit;

        void Start()
        {

        }

        public void PlayerHit()
        {
            playerhit.Notify();
        }
        
    }
}
