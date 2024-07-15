using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GymBeastLike
{
    public class CharacterChangeSkin : MonoBehaviour, ICharacterChangeSkin
    {
        private List<string> skins;
        private SkinnedMeshRenderer boymaterial;
        private SkinnedMeshRenderer shirtmaterial;
        private SkinnedMeshRenderer shortmaterial;
        private int index;
        private void Awake()
        {
            skins = new List<string>()
            {"Color_Palette_1",
            "Color_Palette_2",
            "Color_Palette_3",
            "Color_Palette_4",
            "Color_Palette_5",
            "Color_Palette_6"
            };
            index = 0;
            boymaterial = transform.Find("Character_Boy").GetComponent<SkinnedMeshRenderer>();
            shirtmaterial = transform.Find("Shirt_Boy").GetComponent<SkinnedMeshRenderer>();
            shortmaterial = transform.Find("Pants_Boy").GetComponent<SkinnedMeshRenderer>();
        }

        public void SetNewRandonSkin()
        {
            index++;
            if (index > skins.Count - 1)
            {
                index = 0;
            }

            boymaterial.material = Resources.Load<Material>("Materiais/" + skins[index]);
            shirtmaterial.material = boymaterial.material;
            shortmaterial.material = boymaterial.material;
        }
    }
}