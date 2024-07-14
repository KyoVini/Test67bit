using UnityEngine;

namespace GymBeastLike
{
    [ExecuteInEditMode]
    public class ChangeColor : MonoBehaviour
    {
        [SerializeField] private Color32 newColor = new Color32(255, 255, 255, 255);
        // Start is called before the first frame update
        void Start()
        {
            GetComponent<MeshRenderer>().sharedMaterial.color = newColor;
        }
        public void SetNewColor(Color32 _newcolor)
        {
            GetComponent<MeshRenderer>().sharedMaterial.color = _newcolor;
        }
    }
}
