using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 0.5f;

    public Rigidbody2D rd;

    Vector2 movement;
    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rd.MovePosition(rd.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
