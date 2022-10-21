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

        if (x != 0)
        {
            rb.velocity = rb.velocity + new Vector2(x * 4, 0);
            //transform.position = transform.position + new Vector3(0, 100, 0);
        }

        if(y != 0)
        {
            rb.velocity = rb.velocity + new Vector2(0, y * 4);
            //transform.position = transform.position + new Vector3(100, 0, 0);
        }
	
	Camera camera = Camera.main;
	Vector2 relPos = new Vector2(rb.position.x - camera.transform.position.x, 
		rb.position.y - camera.transform.position.y);
	
	float x_distance_to_border = relPos.x;

	float y_distance_to_border = relPos.y;

	if (Mathf.Abs(x_distance_to_border) + 37.5f > camera.orthographicSize * camera.aspect) {
		rb.velocity = new Vector2(0, rb.velocity.y);
		rb.position = new Vector2((Mathf.Abs(x_distance_to_border) / 
				x_distance_to_border) * (camera.orthographicSize * camera.aspect - 37.6f), rb.position.y);
	}
	
	if (Mathf.Abs(y_distance_to_border) + 40.0f > camera.orthographicSize) {
		rb.velocity = new Vector2(rb.velocity.x, 0);
		rb.position = new Vector2(rb.position.x, (Mathf.Abs(y_distance_to_border) / 
				y_distance_to_border) * (camera.orthographicSize - 40.1f));
	}
    }
}