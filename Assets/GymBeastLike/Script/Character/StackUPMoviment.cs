using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class StackUPMoviment : MonoBehaviour, IMoveControl
    {
        [SerializeField] private float speed = 5.0f;

        public float followSpeed = 10.0f;
        public float followDistance = 0.5f;

        Vector3 move;
        
        public void Move(float h, float v)
        {
            List<GameObject> liststack = StackUP.Instance.GetStackedObjects();
            if(liststack.Count > 0)
            {
                Compensationmove(h, v, liststack);
                UpdateFirstObject(h, v, liststack[0]);
            }
        }

        private void Compensationmove(float h, float v, List<GameObject> liststack)
        {
            int totalenemies = liststack.Count;

            move = transform.right * -h + transform.forward * -v;

            Vector3 rotate = transform.right * h + transform.forward * v;

            for (int i = 0; i < totalenemies; i++)
            {
                if (move != Vector3.zero)
                {
                    liststack[i].transform.localPosition += move * speed * Time.deltaTime;
                    liststack[i].transform.localRotation = Quaternion.LookRotation(rotate, Vector3.up);

                }
            }
        }

        void UpdateFirstObject(float h, float v,GameObject first)
        {
            move = transform.right * h + transform.forward * v;

            Vector3 rotate = transform.right * h + transform.forward * v;
            first.transform.localPosition += move * speed * Time.deltaTime;
            if(rotate != Vector3.zero)
                first.transform.localRotation = Quaternion.LookRotation(rotate, Vector3.up);

        }
        void Update()
        {

            for (int i = 1; i < StackUP.Instance.GetStackedObjects().Count; i++)
            {
                FollowPreviousObject(StackUP.Instance.GetStackedObjects()[i], StackUP.Instance.GetStackedObjects()[i - 1]);
            }
        }

        void FollowPreviousObject(GameObject currentObject, GameObject previousObject)
        {
            float keepY = currentObject.transform.localPosition.y;
            Vector3 direction = (previousObject.transform.localPosition - currentObject.transform.localPosition).normalized;
            float distance = Vector3.Distance(previousObject.transform.localPosition, currentObject.transform.localPosition);

            if (distance > followDistance)
            {
                Vector3 newpos = Vector3.Lerp(
                    currentObject.transform.localPosition,
                    previousObject.transform.localPosition - direction * followDistance,
                    followSpeed * Time.deltaTime
                );

                newpos = new Vector3(newpos.x, keepY, newpos.z);
                currentObject.transform.localPosition = newpos;
                
            }

        }
    }
    
}
