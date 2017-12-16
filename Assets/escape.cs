using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escape : MonoBehaviour {

	public void PlayButton(string SceneName)
	{
		SceneManager.LoadScene("Scene2");
	}

	public void Level2Button(string SceneName)
	{
		SceneManager.LoadScene("Scene1");
	}

	public void QuitButton(string SceneName)
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void QuitGame()
	{
		Debug.Log("Quit!");
		Application.Quit();
	}
}