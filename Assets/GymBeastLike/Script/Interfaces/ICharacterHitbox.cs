using UnityEngine;
using System.Collections.Generic;
namespace GymBeastLike
{
    public interface ICharacterHitbox
    {
        List<GameObject> GetEnemiesHitted();
        void CleanObject(GameObject objtoclean);
    }
}
