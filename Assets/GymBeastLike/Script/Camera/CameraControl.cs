using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class CameraControl : MonoBehaviour, ICameraControl
    {
        private Camera charcamera;
        private bool animated;
        private float startime;
        private float animationtime;
        private Vector3 newposition;
        private Vector3 initialposition;
        private void Awake()
        {
            charcamera = GetComponent<Camera>();
            animated = false;
            animationtime = 1.0f;
        }
        public void SetPositionCamera(Vector3 _newposition)
        {
            initialposition = transform.localPosition;
            newposition = _newposition;
            startime = Time.time;
            animated = true;
            Debug.Log("testeCamera");
        }
        public Camera GetCamera()
        {
            return charcamera;
        }
        private void FixedUpdate()
        {
            if (animated)
            {
                float elapsedTime = Time.time - startime;
                if (elapsedTime < animationtime)
                {
                    float t = EaseCalculation.EaseInOut(elapsedTime / animationtime);
                    Vector3 currentPostion = Vector3.Lerp(initialposition, newposition, t);
                    transform.localPosition = currentPostion;
                }
                else
                {
                    transform.localPosition = newposition;
                    animated = false;
                }
            }

        }
    }
}
