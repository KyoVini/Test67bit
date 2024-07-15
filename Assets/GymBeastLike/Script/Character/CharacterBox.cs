using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class CharacterBox : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.name == "deposit")
            {
                GameManager.Instance.GameDeposit();
            }
            if (other.gameObject.name == "upgrade")
            {
                GameManager.Instance.GameUpgrade();
            }
            if (other.gameObject.name == "wardrobe")
            {
                GameManager.Instance.GameChangeSkin();
            }
        }
       
    }
}
