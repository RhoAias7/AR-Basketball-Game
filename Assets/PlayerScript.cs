using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerScript : MonoBehaviour {

	public float movementSpeed = 10f;

	Rigidbody2D rb;

	float movement = 10f;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//Movement Input
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate(){
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}
