using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Horizontal");
        float x = Input.GetAxis("Vertical");
        controller.Move(transform.forward * x + transform.right * y);
    }
}
