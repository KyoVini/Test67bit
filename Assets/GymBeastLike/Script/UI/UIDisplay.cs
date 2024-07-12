using TMPro;
using UnityEngine;

namespace GymBeastLike
{
    public class UIDisplay : MonoBehaviour, IDisplayChange
    {
        private TextMeshProUGUI lvtxt;
        private TextMeshProUGUI moneytxt;

        void Awake()
        {
            lvtxt = transform.Find("LvDisplay/Lvtxt").GetComponent<TextMeshProUGUI>();
            moneytxt = transform.Find("Money/Moneytxt").GetComponent<TextMeshProUGUI>();
        }

        public void ChangeLvDisplay(string lv)
        {
            lvtxt.text = lv;
        }
        public void ChangeMoneyDisplay(string money)
        {
            moneytxt.text = money;
        }
    }
}