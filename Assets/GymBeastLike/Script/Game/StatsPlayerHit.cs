using UnityEngine;
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
            //
        }
    }
}