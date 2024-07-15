namespace GymBeastLike
{
    public class StateFactory
    {
        private StatsGameStart gamestart;
        private StatsPlayerHit playerhit;
        private StatsGameDeposit deposit;
        private StatsGameUpgrade upgrade;
        private StatsGameChangeSkin changeskin;
        private StatsGameControl gamecontrol;
        
        public StateFactory()
        {
            playerhit = new StatsPlayerHit();
            gamecontrol = new StatsGameControl();
            deposit = new StatsGameDeposit();
            upgrade = new StatsGameUpgrade();
            changeskin = new StatsGameChangeSkin();
            gamestart = new StatsGameStart();
            
        }
    }
}
