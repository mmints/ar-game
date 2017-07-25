using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSync : MonoBehaviour {

    public GameObject obtainTransFrom;

	void FixedUpdate() {
		var remoteTrans = obtainTransFrom.transform;
		transform.position = remoteTrans.position;
		transform.rotation = remoteTrans.rotation;
	}
}
