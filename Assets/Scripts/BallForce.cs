using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour {

	public float force;

	private Rigidbody rb_Ball;

	// Use this for initialization
	void Start () {
		rb_Ball = GetComponent<Rigidbody>();
		//rb_Ball.AddForce (0, 0, force, ForceMode.Impulse);
	}	
}
