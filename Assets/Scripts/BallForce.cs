using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour {

	public float force;

	private Rigidbody rb_Ball;
	private int time;
	// Use this for initialization
	void Start () {
		rb_Ball = GetComponent<Rigidbody>();
		time = 0;
	}

	void Update () {
		if (Input.GetAxis ("Fire") == 1 && time <= 10) {
			rb_Ball.AddForce (0, 0, force, ForceMode.Impulse);
			time += 1;
			Debug.Log ("Add force " + time + " times!");
		}

	}
}