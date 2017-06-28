using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FlipperController : MonoBehaviour {

    public Button inputButton;

	public float restPosition;
	public float pressedPosition;
	public string inputName;

<<<<<<< Updated upstream
    private HingeJoint hinge;
    private bool buttonDown;

    void Start() {
        GetComponent<HingeJoint>().useSpring = true;
        hinge = GetComponent<HingeJoint>();
        inputButton = GetComponent<Button> ();
    }

    void Update() {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (Input.GetButton(inputName) || buttonDown){
            spring.targetPosition = pressedPosition;
            
        } else {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }

    public void HoldButton() {
        buttonDown = true;
    }

    public void ReleaseButton() {
        buttonDown = false;
    }
=======
	private bool btnDown;

	private HingeJoint hinge;

	void Start() {
		Debug.Log ("Start FlipperController");
	}

	void Update() {
		hinge = GetComponent<HingeJoint>();
		bool pressed = Input.GetButton (inputName) || btnDown;
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
>>>>>>> Stashed changes
}
