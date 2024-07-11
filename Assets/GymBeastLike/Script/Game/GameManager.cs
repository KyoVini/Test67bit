using UnityEngine;
namespace GymBeastLike
{
    public class GameManager : Singleton<GameManager>
    {
        private StatusGameNotifier playerhit;
        private StatusControlGameNofifier gamecontrol;

        private StateFactory statefactory;
        // Start is called before the first frame update
        protected override void Awake()
        {
            base.Awake();

            playerhit = new StatusGameNotifier();
            gamecontrol = new StatusControlGameNofifier();
            
            statefactory = new StateFactory();
        }
        public StatusGameNotifier GetPlayerHit() => playerhit;
        public StatusControlGameNofifier GetGameControl() => gamecontrol;

        public void PlayerHit() { playerhit.Notify(); }
        public void GameControl(float horizontal, float vertical) { gamecontrol.Notify(horizontal, vertical); }



    }
}
