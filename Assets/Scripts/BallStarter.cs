using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStarter : MonoBehaviour {

	private float force;
	public float maxForce;

	private Rigidbody rb_Ball;

	private int debugCounter;

	// Use this for initialization
//	void Start () {
//		debugCounter = 0;
//		force = 0;
//	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider ball)
	{
		debugCounter = 0;
		force = 0.0f;
		Debug.Log (ball.gameObject.name + " ball enter start position!");	
	}

	void OnTriggerStay (Collider ball)
	{
		debugCounter += 1;
		Debug.Log (ball.gameObject.name + " stay on start position " + "(" + debugCounter + ")");
		rb_Ball = ball.gameObject.GetComponent<Rigidbody>();

		if (Input.GetAxis ("Fire") == 1 && force <= maxForce) {
			force += 0.1f;
			Debug.Log ("Force: "  + force);
		}
		else{
			rb_Ball.AddForce (0, 0, force, ForceMode.Impulse);
			Debug.Log ("Fire ball!");
		}


	}

}
