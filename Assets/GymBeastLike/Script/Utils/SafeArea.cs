using UnityEngine;

namespace GymBeastLike
{
    public class SafeArea : MonoBehaviour
    {
        RectTransform recttransform;
        Rect safearea;
        Vector2 minanchor;
        Vector2 maxanchor;
        void Awake()
        {
            recttransform = GetComponent<RectTransform>();
            safearea = Screen.safeArea;
            minanchor = safearea.position;
            maxanchor = minanchor + safearea.size;

            minanchor.x /= Screen.width;
            minanchor.y /= Screen.height;
            maxanchor.x /= Screen.width;
            maxanchor.y /= Screen.height;

            recttransform.anchorMin = minanchor;
            recttransform.anchorMax = maxanchor;
        }

    }
}

