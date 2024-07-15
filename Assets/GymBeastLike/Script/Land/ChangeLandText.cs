using TMPro;
using UnityEngine;
namespace GymBeastLike
{
    public class ChangeLandText : MonoBehaviour
    {
        [SerializeField]private TextMeshPro texttoupdate;
        
        // Start is called before the first frame update
        void Awake()
        {
            texttoupdate = transform.Find("UpgradeTxt").GetComponent<TextMeshPro>();
        }

        public void SetText(string _text)
        {
            texttoupdate.text = _text;
        } 
    }
}
