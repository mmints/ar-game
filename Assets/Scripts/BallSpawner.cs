using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject Ball;
	// public Vector3 position;

	public GameObject Spawn;

	void Start () {
		// Instantiate (Ball, position, Quaternion.identity);
		Instantiate (Ball, Spawn.transform.position, Quaternion.identity);
		Debug.Log ("Create new ball.");
	}

}
