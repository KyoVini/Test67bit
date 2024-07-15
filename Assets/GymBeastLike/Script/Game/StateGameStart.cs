
namespace GymBeastLike
{
    public class StatsGameStart : IStatusGame
    {
        public StatsGameStart()
        {
            GameManager.Instance.GetGameStart().Attach(this);
        }
        public void OnDestroy()
        {
            GameManager.Instance.GetGameStart().Detach(this);
        }
        public void OnStatus()
        {
            GamePlayData.Instance.UpdateLv(0);
            GamePlayData.Instance.UpdateMoney(0);
            UIManager.Instance.SetDisplayLv(GamePlayData.Instance.GetLvValue());
            UIManager.Instance.SetDisplayMoney(GamePlayData.Instance.GetMoneyValue());

            KeySceneryManager.Instance.WardrobeLandActive(true);

            CharacterManager.Instance.SetControlable(true);
        }
    }
}
