using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointerMovement : MonoBehaviour
{
    //public Rigidbody2D rb;
    Vector2 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }

    private void FixedUpdate()
    {
        transform.position = mousePosition;
    }
}
