using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (BoxCollider2D))]
public class DetectGameOver : MonoBehaviour {

	Text txt;
	private string updateText;

	void Start(){
		txt = gameObject.GetComponents<Text> ();
		txt.text = "Reach the top!";
		if (gameObject.GetComponent<BoxCollider2D> () == null) {
		}
	}



	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag.Equals("Player")){
			Time.timeScale = 0;
			updateText = PlayerPrefs.GetString ("text");
			PlayerPrefs.SetString("Game Over!");
			Debug.Log ("Game Over"); 
		}
	}
}
