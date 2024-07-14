namespace GymBeastLike
{
    public class StateFactory
    {
        private StatsGameStart gamestart;
        private StatsPlayerHit playerhit;
        private StatsGameDeposit deposit;
        private StatsGameUpgrade upgrade;
        private StatsGameControl gamecontrol;
        
        public StateFactory()
        {
            playerhit = new StatsPlayerHit();
            gamecontrol = new StatsGameControl();
            deposit = new StatsGameDeposit();
            upgrade = new StatsGameUpgrade();
            gamestart = new StatsGameStart();
            
        }
    }
}
