
using UnityEngine;
namespace GymBeastLike
{
    [RequireComponent(typeof(ChangeColor))]
    public class LandActiveControl : MonoBehaviour, ILandActiveControl
    {
        private ChangeColor changecolor;
        private Color32 able;
        private Color32 diable;
        private bool stateable;
        
        private void Awake()
        {
            stateable = false;
            SetisAble(stateable);
            changecolor = GetComponent<ChangeColor>();
            able = new Color32(121, 231, 144, 255);
            diable = new Color32(207, 207, 207, 255);
            
        }
        public void SetisAble(bool _able)
        {
            if (_able && !stateable)
            {
                stateable = true;
                changecolor.SetNewColor(able);
            }
            if(!_able && stateable)
            {
                stateable = false;
                changecolor.SetNewColor(diable);
            }
        }
        public bool GetisAble() => stateable;

    }
}
