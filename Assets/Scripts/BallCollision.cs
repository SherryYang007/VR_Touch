using UnityEngine;
using UnityEngine.Animations;

public class BallCollision : MonoBehaviour {
	Animator myAnim;
	void Start()
	{
		myAnim = GetComponent<Animator>();
	}

	void OnCollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.gameObject.tag == "Player")
		{
			myAnim.SetBool("Open", true);
			Debug.Log("YOU TOUCH BALL");
		}
	}
	private void OnCollisionExit(Collision collision)
	{
		myAnim.SetBool("Open", false);
		Debug.Log("You leave");
	}

}
