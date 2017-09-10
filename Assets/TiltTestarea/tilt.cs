using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour {

	public string inputLeft;
	public string inputRight;
	public float force;

	private Rigidbody rigidBody;
	private int tiltCounter;

	void Start() {
		tiltCounter = 0;
		rigidBody = GetComponent<Rigidbody>();
	}

	void Update() {
		if (Input.GetAxis(inputLeft) == 1 && tiltCounter < 3) {
            tiltCounter++;
            rigidBody.AddForce(-force, 0, 0, ForceMode.Impulse);
            Debug.Log("Tilt left (" + tiltCounter + ")");
        }
        if (Input.GetAxis(inputRight) == 1 && tiltCounter < 3) {
            tiltCounter++;
            rigidBody.AddForce(force, 0, 0, ForceMode.Impulse);
            Debug.Log("Tilt right (" + tiltCounter + ")");
        }
	}
}
