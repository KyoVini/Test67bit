using UnityEngine;
using System.Collections.Generic;
namespace GymBeastLike
{
    public class StatsPlayerHit : IStatusGame
    {
        public StatsPlayerHit()
        {
            GameManager.Instance.GetPlayerHit().Attach(this);
        }
        public void OnDestroy()
        {
            GameManager.Instance.GetPlayerHit().Detach(this);
        }
        public void OnStatus()
        {
            List<GameObject> enemies = CharacterManager.Instance.GetHitbox().GetEnemiesHitted();
            do
            {
                 if (!CharacterManager.Instance.GetCarringMaxEnemies())
                {
                    CharacterManager.Instance.GetStack().StackUpEnemy(enemies[0]);
                }
                CharacterManager.Instance.GetHitbox().CleanObject(enemies[0]);
            
            } while (enemies.Count > 0);
            KeySceneryManager.Instance.DepositLandActive(true);
            CharacterManager.Instance.CamVerifyPosition();

        }
    }
}