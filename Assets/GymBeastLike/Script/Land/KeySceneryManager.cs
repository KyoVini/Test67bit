using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class KeySceneryManager : Singleton<KeySceneryManager>
    {
        private List<Transform> upgrade;
        private List<ILandActiveControl> deposit;
        
        protected override void Awake()
        {
            base.Awake();

            upgrade = new List<Transform>();
            deposit = new List<ILandActiveControl>();
            foreach (Transform child in transform)
            {
                if (child.name == "upgrade")
                {
                    upgrade.Add(child);
                }
                else if (child.name == "deposit")
                {
                    deposit.Add(child.GetComponent<LandActiveControl>());
                }
            }
        }
        public void UpgradeLandActive(bool _active)
        {
            if (upgrade.Count > 0)
            {
                for (int i = 0; i < upgrade.Count; i++)
                {
                    upgrade[i].GetComponent<LandActiveControl>().SetisAble(_active);
                }
            }
        }
        public void DepositLandActive(bool _active)
        {
            if (deposit.Count > 0)
            {
                for(int i = 0;i< deposit.Count; i++)
                {
                    deposit[i].SetisAble(_active);
                }
            }
        }

        public void SetUpgradeLand()
        {
            //verify if the current money is possible buy a upgrade
            if (GamePlayData.Instance.GetMoneyValue() >= GamePlayData.Instance.GetMoneyToUpgrade(GamePlayData.Instance.GetLvValue()))
            {
                UpgradeLandActive(true);
            }
            else
            {
                UpgradeLandActive(false);
            }
        }
        public bool isUpgradeAvaiable()
        {
            bool isup = false;
            if (upgrade.Count > 0)
            {
                isup = upgrade[0].GetComponent<LandActiveControl>().GetisAble();
            }
            return isup;
        }
        public bool isDepositAvaiable()
        {
            bool isup = false;
            if (deposit.Count > 0)
            {
                isup = deposit[0].GetisAble();
            }
            return isup;
        }
        public void SetUpgradeNewValue(string _value)
        {
            if (upgrade.Count > 0)
            {
                for (int i = 0; i < upgrade.Count; i++)
                {
                    upgrade[i].GetComponent<ChangeLandText>().SetText(_value);
                }
            }
        }
        
    }
}
