using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject Ball;
	public Vector3 position;

	void Start () {
			Instantiate (Ball, position, Quaternion.identity);
			Debug.Log ("Create new ball.");
	}

}
