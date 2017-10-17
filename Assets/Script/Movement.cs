using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //rb.velocity = new Vector2(1, 0);

        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector2(1, 0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity -= new Vector2(1, 0);
        }
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, 500));
        }
	}
}
