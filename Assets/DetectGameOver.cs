using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (BoxCollider2D))]
public class DetectGameOver : MonoBehaviour {

	void Start(){
		if (gameObject.GetComponent<BoxCollider2D> () == null) {
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag.Equals("Player")){
			Time.timeScale = 0;
			Debug.Log ("Game Over");
		}
	}
}
