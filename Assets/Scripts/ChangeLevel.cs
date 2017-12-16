using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {


	


		void OnCollliderEnter2D(Collider2D col)
		{
			
		if (col.gameObject.tag == "NextLevel") {
			SceneManager.LoadScene ("NextStage");

		}
		
	}
}
