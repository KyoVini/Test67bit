using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class StackUPMoviment : MonoBehaviour , IMoveControl
    {
        private float speed = 5.0f;
        private float seconds = 0.05f;
        bool moving;
        List<GameObject> stackfollow;
        private void Start()
        {
            stackfollow = new List<GameObject>();
            moving = false;
        }
        public void Move(float h, float v)
        {
            List<GameObject> liststack = StackUP.Instance.GetStackedObjects();
            
            int totalenemies = liststack.Count;
            //desconta o q o jogador andou
            Vector3 move = transform.right * -h + transform.forward * -v;
            Vector3 rotate = transform.right * h + transform.forward * v;
            
            for (int i = 0; i < totalenemies; i++)
            {
                if (move != Vector3.zero)
                {
                    liststack[i].transform.localPosition += move * speed * Time.deltaTime;
                    liststack[i].transform.localRotation = Quaternion.LookRotation(rotate, Vector3.up);
                    if(!moving) Invoke(nameof(setMoving), speed * Time.deltaTime);
                }
            }
        }
        private void setMoving()
        {
            moving = true;
        }
        //private void Update()
       // {
         //   if (moving)
           // {
             //   StackUP.Instance.GetStackedObjects()[0].transform.localPosition
                /*for (int i = 0; i < stackfollow.Count; i++)
                {
                    if()
                }*/

               // moving = false;
                
            //}
        //}

        
    }
    
}
