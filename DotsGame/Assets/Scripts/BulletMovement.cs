using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
	GameObject player;
	GameObject mousePointer;

    float speed = 5f;


    float angle;

    float xMove;
    float yMove;
	// Start is called before the first frame update
	void Start()
	{
        //Debug.Log("hello");
        player = GameObject.Find("Dot");
		mousePointer = GameObject.Find("MousePointer");

        float xDistance = mousePointer.transform.position.x - player.transform.position.x;
        float yDistance = mousePointer.transform.position.y - player.transform.position.y;

        angle = Mathf.Atan(yDistance / xDistance);

        xMove = Mathf.Cos(angle) * speed * Time.deltaTime;
        yMove = Mathf.Sin(angle) * speed * Time.deltaTime;

        if (xDistance < 0)
        {
            xMove = -xMove;
            yMove = -yMove;
        }




    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xMove, yMove, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("testing");
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "MapEdges")
        {
            Debug.Log("collided, and deleting");
            Destroy(gameObject);
        }
    }
}
