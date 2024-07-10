using UnityEngine;

namespace GymBeastLike
{
    public interface ICameraControl
    {
        void SetPositionCamera(Vector3 _newposition);
        public Camera GetCamera();
    }
}