using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStarter : MonoBehaviour {

	public float maxForce;

	private float force;
	private Rigidbody rb_Ball;
	private Vector3 restPosition;

	private int debugCounter;

	void Start()
	{
		foreach (Transform child in transform) {
			restPosition = child.position;
		}

	}

	void OnTriggerEnter (Collider ball)
	{
		debugCounter = 0;
		force = 0.0f;
	}

	void OnTriggerStay (Collider ball)
	{
		debugCounter += 1;
		Debug.Log (ball.gameObject.name + " stay on start position " + "(" + debugCounter + ")");
		rb_Ball = ball.gameObject.GetComponent<Rigidbody>();

		if (Input.GetAxis ("Fire") == 1 && force <= maxForce) {
			force += 0.35f;

			Debug.Log ("Force: "  + force);
		}
		else {
			rb_Ball.AddForce (0, 0, force, ForceMode.Impulse);
			Debug.Log ("Fire ball!");
		}
	}

	void Update(){
		if (Input.GetAxis ("Fire") == 1) {
			foreach (Transform child in transform) {
				child.position -= Vector3.forward * 0.1F;
			}
		}
		else {
			foreach (Transform child in transform) {
				child.position = restPosition;
			}
		}

	}

}
