using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class UIManager : Singleton<UIManager>
    {
        private IDisplayChange hud;
        protected override void Awake()
        {
            base.Awake();
            hud = transform.Find("Safearea/Top").GetComponent<UIDisplay>();
            
        }
        public void SetDisplayLv(int lv)
        {
            string showlv = "LV " + lv;
            hud.ChangeLvDisplay(showlv);
        }
        public void SetDisplayMoney(int money)
        {
            hud.ChangeMoneyDisplay(money.ToString());
        }
    }
}
