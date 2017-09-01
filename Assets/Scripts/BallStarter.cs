using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStarter : MonoBehaviour {

    public Vector3 forceMax = new Vector3(0.0f, 0.0f, 7.0f);
    public Vector3 forceStep = new Vector3(0.0f, 0.0f, 0.2f);
    public float threshold = 0.1f;

    private Vector3 force;
    private Rigidbody rigidBody;
    private bool buttonDown;

    void Start() {}

    void OnTriggerEnter(Collider ball) {
        force = new Vector3();
    }

    void OnTriggerStay(Collider ball) {
        rigidBody = ball.GetComponent<Rigidbody>();
        if (buttonDown &&
             (Mathf.Abs(force.x - forceMax.x) > threshold ||
              Mathf.Abs(force.y - forceMax.y) > threshold ||
              Mathf.Abs(force.z - forceMax.z) > threshold)) {
            force += forceStep;
            Debug.Log("Force: "  + force);
        } else {
            rigidBody.AddForce(force.x, force.y,
                force.z, ForceMode.Impulse);
        }
    }

    public void HoldButton() {
        buttonDown = true;
    }

    public void ReleaseButton() {
        buttonDown = false;
    }
}
