
namespace GymBeastLike
{
    public class StatsGameUpgrade : IStatusGame
    {
        public StatsGameUpgrade()
        {
            GameManager.Instance.GetGameUpgrade().Attach(this);
        }
        public void OnDestroy()
        {
            GameManager.Instance.GetGameUpgrade().Detach(this);
        }
        public void OnStatus()
        {
            
            if (KeySceneryManager.Instance.isUpgradeAvaiable() )
            {
                int monyspend = GamePlayData.Instance.GetMoneyToUpgrade(GamePlayData.Instance.GetLvValue()) * -1;
                GamePlayData.Instance.UpdateMoney(monyspend);

                GamePlayData.Instance.UpdateLv();
                KeySceneryManager.Instance.SetUpgradeNewValue(GamePlayData.Instance.GetMoneyToUpgrade(GamePlayData.Instance.GetLvValue()) +" $");
                KeySceneryManager.Instance.SetUpgradeLand();

            }
        }
    }
}
