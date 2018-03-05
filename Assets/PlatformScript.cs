using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour {
	[SerializeField]
	public float jumpForce = 1000000f;

	//A call-back method* for whenever an object collides with another object
	void OnCollisionEnter2D(Collision2D collision){

		if (collision.relativeVelocity.y <= 0f) {
			//Collect information about the collision
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D> ();

			//if a rigidbody is found on the object collided on 
			if (rb != null) {

				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
				rb.velocity = velocity;
			}
		}
	}

}
