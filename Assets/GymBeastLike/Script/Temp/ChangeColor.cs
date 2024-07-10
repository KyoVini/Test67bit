using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color32 newColor = new Color32(255,255,255,255);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = newColor;
    }

}
