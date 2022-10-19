using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // this cannot be executed if it is already attached to a game object. (However this will automatically attach the component to the game object.
// e.g you dont need to add 'RigidBody' to the game object in the inspector.

public class ForceMovement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward *= speed); // * speed only gives a push and then stops the force, *= speed continuously applies force
    }



}
