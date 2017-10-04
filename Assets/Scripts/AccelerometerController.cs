using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use this script with the ball prefab

public class AccelerometerController : MonoBehaviour {

	public float force;
    public int maxCount;
	private float acc;
	private Rigidbody ball;
	private float vz;
    public int counter;
    
    void Start() {
		ball = GetComponent<Rigidbody>();
        counter = 0;
	}

	void Update ()
	{
		acc = Input.acceleration.x;
		vz = acc / -acc;
		if ((acc > 0.2 || acc < -0.2) && (counter < maxCount)) {
			ball.AddForce (vz * force, 0, 0, ForceMode.Impulse);
            counter++;
		}
	}
}
