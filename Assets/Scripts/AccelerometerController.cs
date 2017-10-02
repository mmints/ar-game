using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use this script with the ball prefab

public class AccelerometerController : MonoBehaviour {

	public float force = 100;
	private float acc;
	private Rigidbody ball;
	private float vz;

	void Start() {
		ball = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		acc = Input.acceleration.x;
		vz = acc / -acc;

		if (acc > 0.2 || acc < -0.2) {
			ball.AddForce (vz * force, 0, 0, ForceMode.Impulse);
		}


	}
}
