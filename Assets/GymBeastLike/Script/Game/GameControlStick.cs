using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GymBeastLike
{
    public class GameControlStick : MonoBehaviour
    {
        private void Update()
        {
            if (CharacterManager.Instance.GetControlable())
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");
                GameManager.Instance.GameControl(h, v);
            }
        }
    }
}
