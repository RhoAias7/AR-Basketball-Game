using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketBall : MonoBehaviour {

	public Text score;

	private int currentScore = 0;
	private Vector3 IntialPosition;
	private TouchManager touchsystem;

	void Start()
	{
		touchsystem = GameObject.FindObjectOfType<TouchManager>().GetComponent<TouchManager>();
		IntialPosition = this.transform.position; //set initial position to current ball
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Ring") {
			ScoreUpdate();
		} 
	}

	private void ScoreUpdate()
	{
		currentScore++;
		score.text = currentScore.ToString();
	}

	public void ResetPosition()
	{
		this.transform.position = IntialPosition + new Vector3(Random.RandomRange(-20f, 20f), 0f, 0f);
		this.GetComponent<Rigidbody>().useGravity = false;
		this.GetComponent<Rigidbody>().isKinematic = true;
		this.GetComponent<Rigidbody>().velocity = Vector3.zero;
		touchsystem.canSwipe = true;
	}

}
	