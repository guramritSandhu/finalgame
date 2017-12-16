using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    Transform mTarget;
    [SerializeField]
    float mFollowSpeed;
    [SerializeField]
    float mFollowRange;

    float mArriveThreshold = 0.05f;

	void Start(){
		mTarget = GameObject.FindGameObjectWithTag ("Player").transform;
	}

    void Update ()
    {
        if(mTarget != null && Time.timeScale != 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, mTarget.transform.position, mFollowSpeed);
            // TODO: Make the enemy follow the target "mTarget"
            //       only if the target is close enough (distance smaller than "mFollowRange")
            ////      Get distance by simple substraction.
            
        }

		if (mTarget) {
			if (mTarget.position.x > transform.position.x && mTarget.position.x > transform.position.x) {
				Vector3 newScale = new Vector3(Mathf.Abs (transform.localScale.x), transform.localScale.y, transform.localScale.z);
				transform.localScale = newScale;
			} else {
				Vector3 newScale = new Vector3(-Mathf.Abs (transform.localScale.x), transform.localScale.y, transform.localScale.z);
				transform.localScale = newScale;
			}
		}
    }

    public void SetTarget(Transform target)
    {
        mTarget = target;
    }
}
