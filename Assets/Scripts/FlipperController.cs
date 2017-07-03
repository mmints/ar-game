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

    void HoldButton() {
        btnDown = true;
    }

    void ReleaseButton() {
        btnDown = false;
    }
}
