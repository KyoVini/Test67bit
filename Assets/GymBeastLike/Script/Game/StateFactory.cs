namespace GymBeastLike
{
    public class StateFactory
    {
        private StatsGameStart gamestart;
        private StatsPlayerHit playerhit;
        private StatsGameControl gamecontrol;
        public StateFactory()
        {
            playerhit = new StatsPlayerHit();
            gamecontrol = new StatsGameControl();
            gamestart = new StatsGameStart();
        }
    }
}
