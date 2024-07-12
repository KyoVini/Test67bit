namespace GymBeastLike
{
    public class GamePlayData : Singleton<GamePlayData>
    {
        private int lv;
        private int money;
        void Start()
        {
            lv = 0;
            money = 0;
        }

        public void UpdateLv(int _lv)
        {
            lv += _lv;
        }
        public void UpdateMoney(int _money)
        {
            money += _money;
        }
        public int GetLvValue() => lv;
        public int GetMoneyValue() => money;
    }
}
