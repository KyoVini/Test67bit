using UnityEngine;
namespace GymBeastLike
{
    public class GameManager : Singleton<GameManager>
    {
        private StatusGameNotifier gamestart;
        private StatusGameNotifier playerhit;
        private StatusControlGameNofifier gamecontrol;

        private StateFactory statefactory;
        // Start is called before the first frame update
        protected override void Awake()
        {
            base.Awake();

            gamestart = new StatusGameNotifier();
            playerhit = new StatusGameNotifier();
            gamecontrol = new StatusControlGameNofifier();
            

            statefactory = new StateFactory();
        }
        private void Start()
        {
            StartGame();
        }
        public StatusGameNotifier GetGameStart() => gamestart;
        public StatusGameNotifier GetPlayerHit() => playerhit;
        public StatusControlGameNofifier GetGameControl() => gamecontrol;

        public void StartGame() { gamestart.Notify(); }
        public void PlayerHit() { playerhit.Notify(); }
        public void GameControl(float horizontal, float vertical) { gamecontrol.Notify(horizontal, vertical); }



    }
}
