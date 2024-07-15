using UnityEngine;
using System.Collections.Generic;
namespace GymBeastLike
{
    public class StatsGameChangeSkin : IStatusGame
    {
        public StatsGameChangeSkin()
        {
            GameManager.Instance.GetGameChangeSkin().Attach(this);
        }
        public void OnDestroy()
        {
            GameManager.Instance.GetGameChangeSkin().Detach(this);
        }
        public void OnStatus()
        {
            CharacterManager.Instance.GetChangeSkin().SetNewRandonSkin();

        }
    }
}
