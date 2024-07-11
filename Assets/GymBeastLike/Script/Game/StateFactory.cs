namespace GymBeastLike
{
    public class StateFactory
    {
        private StatsPlayerHit playerhit;
        private StatsGameControl gamecontrol;
        public StateFactory()
        {
            playerhit = new StatsPlayerHit();
            gamecontrol = new StatsGameControl();
        }
    }
}
