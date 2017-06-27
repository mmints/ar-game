using UnityEngine;
using System.Collections;

public class ObjectForce : MonoBehaviour {

    public int points;
    public float force;

    private Rigidbody rigidBody;

    void Start() {}

    void OnCollisionEnter(Collision collision) {
        var gameObject = collision.gameObject;
        rigidBody = gameObject.GetComponent<Rigidbody>();
        rigidBody.AddExplosionForce(force, this.transform.position, 5);

        // TODO: implement global point counter
    }
}
