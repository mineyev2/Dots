using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 0.5f;

    public Rigidbody2D rd;
    public GameObject bulletPrefab;
    //public Transform mousePointer;

    Vector2 movement;
    // Update is called once per frame

    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    private void FixedUpdate()
    {
        rd.MovePosition(rd.position + movement * movementSpeed * Time.fixedDeltaTime);
        //transform.Translate(movement * movementSpeed * Time.fixedDeltaTime);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }
}
