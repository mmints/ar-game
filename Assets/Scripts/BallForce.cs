using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour {

    public float force;

    private Rigidbody rigidBody;
    private int time;

    void Start() {
        rigidBody = GetComponent<Rigidbody>();
        time = 0;
    }

    void Update() {
        if (Input.GetAxis("Fire") == 1 && time <= 10) {
            rigidBody.AddForce(0, 0, force, ForceMode.Impulse);
            time++;
            Debug.Log("Added force " + time + " times!");
        }
    }
}
