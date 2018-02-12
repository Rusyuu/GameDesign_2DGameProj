using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour {

    public Rigidbody2D rb2d;
    public Vector2 velocity;
    public int testSpeed;

	// Use this for initialization
	void Start () {

        velocity.x = testSpeed;
        velocity.y = Random.Range(-testSpeed / 2, testSpeed / 2);

        rb2d.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            velocity.y = -velocity.y;
        }
        else if( collision.gameObject.tag == "Paddle")
        {
            velocity.x = -velocity.x;
            velocity.x *= 1.05f;
        }

        rb2d.velocity = velocity;
    }
}
