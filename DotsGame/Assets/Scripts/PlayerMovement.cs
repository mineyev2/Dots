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

    public float shootInterval = 0.3f;
    float time;
    // Update is called once per frame
    private void Start()
    {
        time = Time.time;
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButton(0))
        {
            if (Time.time - time > shootInterval)
            {
                Shoot();
                time = Time.time;
            }
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