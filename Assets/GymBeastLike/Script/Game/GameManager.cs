using UnityEngine;
namespace GymBeastLike
{
    public class GameManager : Singleton<GameManager>
    {
        private Notifier playerhit;
        private StateFactory statefactory;
        // Start is called before the first frame update
        protected override void Awake()
        {
            base.Awake();
            //Game Stats

            playerhit = new Notifier();
            // add  more stats

            //
            statefactory = new StateFactory();
            
        }
        public Notifier GetPlayerHit() => playerhit;

        void Start(){        }
        
        public void PlayerHit() { playerhit.Notify(); }
            
        
        
    }
}
