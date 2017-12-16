using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jamminger : MonoBehaviour
{
	[SerializeField]
    GameObject mExplosionPrefab;

	public Text ScoreText;
	static int score = 0;

	private Animator Enemy_Animator;


    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject.layer == LayerMask.NameToLayer("BusterBullet"))
        {
            //Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
			GetComponent<Animator> ().SetTrigger ("Death");

			GetComponent<BoxCollider2D> ().enabled = false;
			GetComponent<FollowTarget> ().enabled = false;
			Invoke ("DistroyEnemy",2f);
			score++;
			//GameObject.Find ("Score").GetComponents<Text> ().text = "Score:" + score;
        }
    }

	public void FixedUpdate(){
		GetComponent<Animator> ().SetBool ("Attacking", false);
	}

    void OnTriggerStay2D(Collider2D col)
    {
       
		if (col.gameObject.layer == LayerMask.NameToLayer ("Player")) {
			col.GetComponent<MegaMan> ().TakeDamage (3);
			GetComponent<Animator>().SetBool ("Attacking", true);
		}

    }

	void DistroyEnemy(){
		Destroy (gameObject);
	}
}
