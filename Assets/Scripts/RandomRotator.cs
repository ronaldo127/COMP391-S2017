using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RandomRotator : MonoBehaviour {

    public float tumble;

    private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.value * tumble;
	}
	
}
