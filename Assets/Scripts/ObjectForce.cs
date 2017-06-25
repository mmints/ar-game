using UnityEngine;
using System.Collections;

public class ObjectForce : MonoBehaviour {

	public float force;
	private Rigidbody rb;

	public int points;

	void start () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		
		rb = col.gameObject.GetComponent<Rigidbody>();
		rb.AddExplosionForce (force, this.transform.position, 5);

		// TODO: Implemets global point counter
	}
		
}