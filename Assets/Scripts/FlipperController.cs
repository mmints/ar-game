using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FlipperController : MonoBehaviour {

	public float restPosition;
	public float pressedPosition;

	private bool btnDown;

	private HingeJoint hinge;

	void Start() {
		Debug.Log ("Start FlipperController");
	}

	void Update() {
		hinge = GetComponent<HingeJoint>();
		bool pressed = btnDown;
		var spring = hinge.spring;
		spring.targetPosition = pressed ? pressedPosition : restPosition;
		hinge.spring = spring;
		hinge.useSpring = true;
	}

	public void holdButton() {
		btnDown = true;
	}

	public void releaseButton() {
		btnDown = false;
	}

}
