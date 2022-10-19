using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // this cannot be executed if it is already attached to a game object. (However this will automatically attach the component to the game object.
// e.g you dont need to add 'RigidBody' to the game object in the inspector.

public class VelocityMovement : MonoBehaviour
{

    public float speed = 5f;

    public Rigidbody rb;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.forward * speed;
    }
}
