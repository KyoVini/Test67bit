namespace GymBeastLike
{
    public class GamePlayData : Singleton<GamePlayData>
    {
        private int currentlv;
        private int currentmoney;
        //setup of each phase could be done via scriptable object
        private int maxlv;
        private int[] moneylvup;
        private int[] enemiescancarry;
        protected override void Awake()
        {
            base.Awake();
            currentlv = 1;
            maxlv = 3;
            currentmoney = 0;
            moneylvup = new int[]{ 20, 30, 50};
            enemiescancarry = new int[] { 3, 5, 10 };
        }

        public void UpdateLv(int _lv=1){ 

            currentlv += _lv;
            UIManager.Instance.SetDisplayLv(currentlv);
        }
        public void UpdateMoney(int _money){ 

            currentmoney += _money;
            UIManager.Instance.SetDisplayMoney(currentmoney);
        
        }
        public int GetLvValue() => currentlv;
        public int GetMoneyValue() => currentmoney;
        public int GetEnemiesCanCarry(int _targetlv =-1) { 
            if(_targetlv > maxlv)
            {
                _targetlv = maxlv;
            }
            if(_targetlv == -1)
            {
                return enemiescancarry[currentlv - 1];
            }
            else
            {
                
                return enemiescancarry[_targetlv - 1]; ;
            }
        }
        public int GetMoneyToUpgrade(int _targetlv = -1)
        {
            if (_targetlv > maxlv)
            {
                _targetlv = maxlv;
            }
            if (_targetlv == -1)
            {
                return moneylvup[currentlv - 1];
            }
            else
            {

                return moneylvup[_targetlv - 1]; ;
            }
        }
    }
}
