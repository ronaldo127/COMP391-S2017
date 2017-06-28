using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour {
    private Rigidbody2D rigidbody2d;
    public float speed;

    // Use this for initialization
    void Start () {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = Vector2.right * speed;
	}
	
}
