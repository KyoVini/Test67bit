using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class StackUP : MonoBehaviour
    {
        private List<GameObject> enemiesstacks;
        private float currenty;
        void Awake()
        {
            enemiesstacks = new List<GameObject>();
            currenty = 0;
        }
        public void StackUpEnemy(GameObject newenemy)
        {
            
            enemiesstacks.Add(newenemy);
            
            float lastheigh = enemiesstacks[enemiesstacks.Count - 1].GetComponent<MeshRenderer>().bounds.size.y;

            enemiesstacks[enemiesstacks.Count - 1].transform.SetParent(this.transform);
            
            Vector3 newposition = new Vector3(0f, lastheigh , 0f);
            enemiesstacks[enemiesstacks.Count - 1].transform.localPosition = newposition;


        }
        
    }
}