using UnityEngine;
using System.Collections.Generic;
namespace GymBeastLike
{
    public class StatsGameControl : IStatusGameController
    {
        public StatsGameControl()
        {
            GameManager.Instance.GetGameControl().Attach(this);
        }
        public void OnDestroy()
        {
            GameManager.Instance.GetGameControl().Detach(this);
        }
        public void OnStatus(float horizontal, float vertical)
        {
            CharacterManager.Instance.GetCharacterMovement().Move(horizontal, vertical);
            CharacterManager.Instance.GetStackMovemet().Move(horizontal, vertical);
        }
    }
}
