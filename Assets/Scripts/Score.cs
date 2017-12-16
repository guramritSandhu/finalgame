using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text ScoreText;
	int score=0;

	public void UpdateScore()
	{
		score++;
		ScoreText.text = "Score:" + score;
	}
}
