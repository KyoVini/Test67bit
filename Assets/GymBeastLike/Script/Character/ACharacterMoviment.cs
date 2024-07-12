using UnityEngine;
namespace GymBeastLike
{
    public abstract class ACharacterMoviment : MonoBehaviour, IMoveControl, ICheckMove
    {
        public abstract bool IsMoving();
        public abstract void Move(float horizontal, float vertical);
        
    }
}
