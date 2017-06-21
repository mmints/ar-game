using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour {

	public string inputName;

	private int tiltCounter;

	void Start () {
		tiltCounter = 0;
	}
	

	void Update () {
		if (Input.GetAxis(inputName) == 1)
		{
			tiltCounter += 1; 
		}

		
	}
}
