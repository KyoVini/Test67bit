using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class StackUP : Singleton<StackUP>, IStackUP
    {
        private List<GameObject> enemiesstacks;
        protected override void Awake()
        {
            base.Awake();
            enemiesstacks = new List<GameObject>();
        }
        public void StackUpEnemy(GameObject newenemy)
        {
            enemiesstacks.Add(newenemy);
            
            enemiesstacks[enemiesstacks.Count - 1].layer = LayerChange.GetLayer();
            enemiesstacks[enemiesstacks.Count - 1].transform.SetParent(this.transform);
            float lastx = 0;
            float lastz = 0;
            float currentheigh = enemiesstacks[enemiesstacks.Count - 1].GetComponent<MeshRenderer>().bounds.size.y;
            if (enemiesstacks.Count == 1)
            {
                currentheigh = currentheigh / 2;
            }
            else
            {
                float lastposition = enemiesstacks[enemiesstacks.Count - 2].transform.localPosition.y;
                float lastheigth = enemiesstacks[enemiesstacks.Count - 2].GetComponent<MeshRenderer>().bounds.size.y;
                float currentposition = lastposition + (lastheigth / 2);
                lastx = enemiesstacks[enemiesstacks.Count - 2].transform.localPosition.x;
                lastz = enemiesstacks[enemiesstacks.Count - 2].transform.localPosition.z;
                currentheigh = (currentheigh / 2) + currentposition;
            }

            Vector3 newposition = new Vector3(lastx, currentheigh, lastz);
            enemiesstacks[enemiesstacks.Count - 1].transform.localPosition = newposition;
        }
        public List<GameObject> GetStackedObjects() => enemiesstacks;
    }
}