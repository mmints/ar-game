using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour {

    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    public string inputName;

    private HingeJoint hinge;

    void Start() {
        GetComponent<HingeJoint>().useSpring = true;
        hinge = GetComponent<HingeJoint>();
    }

    void Update() {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1 || Input.GetButton(inputName)) {
            spring.targetPosition = pressedPosition;
            Debug.Log("Hit left flipper");
        } else {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
