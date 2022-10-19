using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class ControllerMovement : MonoBehaviour
{
    float speed = 5f;
    CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        cc.Move(Vector3.forward * speed * Time.deltaTime);
    }
}
