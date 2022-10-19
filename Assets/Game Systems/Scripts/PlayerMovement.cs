using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script can be found in the component section under the option Game Systems / Player / Movement
[AddComponentMenu("Game Systems / Player / Movement")]
[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    [Header("Character")]

    public Vector3 moveDir;

    private CharacterController _charC;

    [Header("Characters Speed")]

    public float speed = 5f;

    // Dont add a header to a grouping of variables, otherwise it looks spazo.

    public float jumpSpeed = 8f, gravity = 20f, couch = 2.5f, walk = 5f, run = 10f; // If they are the same type you can put multiple variables on the same line.

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _charC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       if (_charC.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            moveDir = transform.TransformDirection(moveDir);

            moveDir *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDir.y = jumpSpeed;
            }

        }

        moveDir.y -= gravity * Time.deltaTime;

        _charC.Move(moveDir * Time.deltaTime);

    }
}
