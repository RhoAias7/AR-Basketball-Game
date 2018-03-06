using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketBall : MonoBehaviour {

	public Text score;

	private int currentScore = 0;

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
}
