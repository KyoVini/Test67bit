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
            for(int i =0; i<enemies.Count; i++)
            {
                CharacterManager.Instance.GetStack().StackUpEnemy(enemies[i]);
            }
            //clean enemies hitbox
            
        }
    }
}