using UnityEngine;
using System.Collections.Generic;
namespace GymBeastLike
{
    public interface IStackUP
    {
        void StackUpEnemy(GameObject newenemy);
        List<GameObject> GetStackedObjects();
        public void CleanObject(GameObject objtoclean);
    }
}