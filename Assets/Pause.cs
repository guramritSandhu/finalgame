using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public bool IsPaused;

	public GameObject PauseText;

	public GameObject RestartText;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		if (IsPaused)
		{
            PauseText.SetActive(true);

            RestartText.SetActive(true);
			Time.timeScale = 0f;
		}
		else
		{
            PauseText.SetActive(false);
            RestartText.SetActive(false);
			Time.timeScale = 1f;
		}


		if (Input.GetKeyDown(KeyCode.Escape))
		{
			IsPaused = !IsPaused;
		}
	}
}