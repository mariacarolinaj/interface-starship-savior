using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //Debug.Log(x);

        if (x != 0)// && rb.velocity.x < 60) 
        {
            rb.velocity = rb.velocity + new Vector2(x * 4, 0);
            //transform.position = transform.position + new Vector3(0, 100, 0);
        }

        if(y != 0)// && rb.velocity.y < 60)
        {
            rb.velocity = rb.velocity + new Vector2(0, y * 4);
            //transform.position = transform.position + new Vector3(100, 0, 0);
        }
    }
}