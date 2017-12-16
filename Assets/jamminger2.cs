using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jamminger2 : MonoBehaviour
{
	public Text ScoreText;
	static int Score = 0;

	[SerializeField]
	GameObject mExplosionPrefab;

	void OnTriggerEnter2D(Collider2D col)
	{

		if (col.gameObject.layer == LayerMask.NameToLayer("BusterBullet"))
		{

			Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
			Destroy(col.gameObject);
			Destroy(gameObject);
			Updatescore();
		}

	}


	void OnTriggerStay2D(Collider2D col)
	{

		if (col.gameObject.layer == LayerMask.NameToLayer("Player"))
		{
			col.GetComponent<MegaMan>().TakeDamage(5);
		}
	}

	public void Updatescore()
	{
		Score = Score+10;
		ScoreText.text = "Score=" + Score;
	}

}
