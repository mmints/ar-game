using UnityEngine;
using System.Collections;

public class ObjectForce : MonoBehaviour {

	public float force;
	private Rigidbody rb;

	private int points;

	void start () {
		points = 0;
	}

	void OnCollisionEnter (Collision col)
	{
		
		rb = col.gameObject.GetComponent<Rigidbody>();
		rb.AddExplosionForce (force, this.transform.position, 5);
		points += 100;
	}

	void OnGUI() {
		GUILayout.Label("\n" + "Points: " + points);
	}

}