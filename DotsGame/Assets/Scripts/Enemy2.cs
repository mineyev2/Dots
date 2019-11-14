using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MovingObject
{
    GameObject player;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector2 direction = player.transform.position - transform.position;
        float magnitude = direction.magnitude;
        move = new Vector2(direction.x / magnitude, direction.y / magnitude);
        transform.Translate(move * Time.deltaTime * speed);
    }
}
