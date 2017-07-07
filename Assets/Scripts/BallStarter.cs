using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStarter : MonoBehaviour {

    public float maxForce;

    private float force;
    private Rigidbody rigidBody;

    private bool buttonDown;

    void Start() {}

    void OnTriggerEnter(Collider ball) {
        force = 0.0f;
    }

    void OnTriggerStay(Collider ball) {
        rigidBody = ball.GetComponent<Rigidbody>();
        if (buttonDown && force <= maxForce) {
            force += 0.2f;
            Debug.Log("Force: "  + force);
        } else {
            rigidBody.AddForce(0, 0, force, ForceMode.Impulse);
        }
    }

    public void HoldButton() {
        buttonDown = true;
    }

    public void ReleaseButton() {
        buttonDown = false;
    }
}
