using UnityEngine;
using System.Collections;

public class ObjectForce : MonoBehaviour {

	public float force;
	private Rigidbody rb;

	void OnCollisionEnter (Collision col)
	{
		
		rb = col.gameObject.GetComponent<Rigidbody>();
		rb.AddExplosionForce (force, this.transform.position, 5);
		Debug.Log (col.gameObject.name + " hits ");
	}
}
