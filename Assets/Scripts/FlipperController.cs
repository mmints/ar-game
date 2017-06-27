using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FlipperController : MonoBehaviour {

    public Button inputButton;

    public float restPosition;
    public float pressedPosition;
    public float hitStrenght;
    public float flipperDamper;
    public string inputName;

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
}
