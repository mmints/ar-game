using UnityEngine;
using System.Collections;

public class BallKiller : MonoBehaviour {

	private BallSpawner bs;

	void OnCollisionEnter (Collision col)
	{
			Debug.Log (col.gameObject.name + " was killed!");
			Destroy(col.gameObject);
	}
}