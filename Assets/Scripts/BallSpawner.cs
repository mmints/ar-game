using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ball;
    public GameObject spawn;

    void Start() {
        Instantiate(ball, spawn.transform.position, Quaternion.identity);
        Debug.Log("Created new ball.");
    }
}
