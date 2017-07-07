using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollisions : MonoBehaviour {

    // Assuming only one instance of Ball exists
    public int collisionCount = 0;
    public Text collisionText;

    void Start() {
        collisionCount = 0;
    }

    void OnCollisionEnter(Collision hit) {
        if (hit.gameObject.GetComponent<PointEvent>() != null) {
            collisionCount++;
            collisionText.text = "Total Points: " + collisionCount;
        }
    }
}
