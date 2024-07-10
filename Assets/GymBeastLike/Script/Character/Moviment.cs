using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    private CharacterController charactercontroller;
    private float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        charactercontroller = GetComponent<CharacterController>();
        if(charactercontroller == null)
        {
            charactercontroller = gameObject.AddComponent(typeof(CharacterController)) as CharacterController;
        }
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;

        charactercontroller.Move(move * speed * Time.deltaTime);
    }
}
