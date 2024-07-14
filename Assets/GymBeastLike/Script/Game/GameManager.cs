using UnityEngine;
namespace GymBeastLike
{
    public class GameManager : Singleton<GameManager>
    {
        private StatusGameNotifier gamestart;
        private StatusGameNotifier playerhit;
        private StatusGameNotifier deposit;
        private StatusGameNotifier DisplayMoney;
        private StatusGameNotifier upgrade;
        private StatusControlGameNofifier gamecontrol;

        private StateFactory statefactory;
        // Start is called before the first frame update
        protected override void Awake()
        {
            base.Awake();

            gamestart = new StatusGameNotifier();
            playerhit = new StatusGameNotifier();
            deposit = new StatusGameNotifier();
            upgrade = new StatusGameNotifier();
            gamecontrol = new StatusControlGameNofifier();
            
            statefactory = new StateFactory();
        }
        private void Start()
        {
            StartGame();
        }
        public StatusGameNotifier GetGameStart() => gamestart;
        public StatusGameNotifier GetPlayerHit() => playerhit;
        public StatusGameNotifier GetGameDeposit() => deposit;
        public StatusGameNotifier GetGameUpgrade() => upgrade;
        public StatusControlGameNofifier GetGameControl() => gamecontrol;

        public void StartGame() { gamestart.Notify(); }
        public void PlayerHit() { playerhit.Notify(); }
        public void GameDeposit() { deposit.Notify(); }
        public void GameUpgrade() { upgrade.Notify(); }
        public void GameControl(float horizontal, float vertical) { gamecontrol.Notify(horizontal, vertical); }



    }
}
