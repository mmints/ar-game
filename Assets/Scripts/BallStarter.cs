using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStarter : MonoBehaviour {

    public float maxForce;
    public string inputName;

    private float force;
    private Rigidbody rigidBody;

    private int debugCounter;

    void Start() {}

    void OnTriggerEnter(Collider ball) {
        debugCounter = 0;
        force = 0.0f;
    }

    void OnTriggerStay(Collider ball) {
        debugCounter++;
        //Debug.Log(ball.gameObject.name + " stay on start position " + "(" + debugCounter + ")");

        rigidBody = ball.GetComponent<Rigidbody>();
        if (Input.GetAxis(inputName) == 1 && force <= maxForce) {
            force += 0.2f;
            Debug.Log("Force: "  + force);
        } else {
            rigidBody.AddForce(0, 0, force, ForceMode.Impulse);
        }
    }
}
