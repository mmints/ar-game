using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject Ball;
    public GameObject Spawn;

    void Start() {
        Instantiate(Ball, Spawn.transform.position, Quaternion.identity);
        Debug.Log("Created new ball.");
    }
}
