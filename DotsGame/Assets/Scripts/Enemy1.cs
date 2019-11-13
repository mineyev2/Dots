using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    GameObject player;
    public float speed = 15f;
    // Start is called before the first frame update
    Vector2 move;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector2 direction = player.transform.position - transform.position;
        float magnitude = direction.magnitude;
        move = new Vector2(direction.x / magnitude, direction.y / magnitude);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move * Time.deltaTime * speed);
    }
}
