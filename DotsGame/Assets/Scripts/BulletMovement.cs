using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
	GameObject player;
	GameObject mousePointer;

    float speed = 100f;

    float angle;

    float xMove;
    float yMove;
    // Start is called before the first frame update


    Vector2 mPrevPos;

    void Start()
	{
        mPrevPos = new Vector2(transform.position.x, transform.position.y);

        player = GameObject.FindGameObjectWithTag("Player");
        mousePointer = GameObject.FindGameObjectWithTag("Pointer");

        float xDistance = mousePointer.transform.position.x - player.transform.position.x;
        float yDistance = mousePointer.transform.position.y - player.transform.position.y;

        //edit this bullshit cuz its ugly and i can do better
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

        Debug.DrawLine(new Vector2(transform.position.x, transform.position.y), mPrevPos, Color.green, 2);

        //doesnt work with edge collider; only box colliders
        RaycastHit2D[] hits = Physics2D.RaycastAll(new Vector2(transform.position.x, transform.position.y), (new Vector2(transform.position.x, transform.position.y) - mPrevPos).normalized, (new Vector2(transform.position.x, transform.position.y) - mPrevPos).magnitude);
        for (int i = 0; i < hits.Length; i++)
        {
            Debug.Log(hits[i].collider.gameObject.name);
            if (hits[i].collider.gameObject.tag == "Map")
            {
                Debug.Log("destroying");
                Destroy(gameObject);
            }
        }
        mPrevPos = new Vector2(transform.position.x, transform.position.y);
    }
}
