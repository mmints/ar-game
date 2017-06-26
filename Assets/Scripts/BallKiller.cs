using UnityEngine;
using System.Collections;

public class BallKiller : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
        var gameObject = collision.gameObject;
        Debug.Log(gameObject.name + " was killed!");
        Destroy(gameObject);
    }
}
