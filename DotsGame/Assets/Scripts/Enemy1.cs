﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    GameObject player;
    // Start is called before the first frame update
    Vector2 move;
    void Start()
    {
        speed = 20f;
        player = GameObject.FindGameObjectWithTag("Player");
        Vector2 direction = player.transform.position - transform.position;
        float magnitude = direction.magnitude;
        move = new Vector2(direction.x / magnitude, direction.y / magnitude);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Enemy");
        transform.Translate(move * Time.deltaTime * speed);
    }

    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}