using UnityEngine;
using System.Collections.Generic;
namespace GymBeastLike
{
    public class StatsGameDeposit : IStatusGame
    {
        public StatsGameDeposit()
        {
            GameManager.Instance.GetGameDeposit().Attach(this);
        }
        public void OnDestroy()
        {
            GameManager.Instance.GetGameDeposit().Detach(this);
        }
        public void OnStatus()
        {
            if (KeySceneryManager.Instance.isDepositAvaiable())
            {
                List<GameObject> enemies = CharacterManager.Instance.GetStack().GetStackedObjects();
                do { 
                    GamePlayData.Instance.UpdateMoney(10);
                    CharacterManager.Instance.GetStack().CleanObject(enemies[0]);
                } while (enemies.Count > 0) ;

                KeySceneryManager.Instance.DepositLandActive(false);

                KeySceneryManager.Instance.SetUpgradeLand();

                CharacterManager.Instance.CamVerifyPosition();
            }
        }
    }
}
