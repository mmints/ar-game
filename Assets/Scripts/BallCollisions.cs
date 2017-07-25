using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollisions : MonoBehaviour {

    public int collisionCount;
    public Text collisionText;

    private bool gameOver;

    void Start() {
        collisionCount = 0;
    }

    void OnCollisionEnter(Collision hit) {
        if (hit.gameObject.GetComponent<PointEvent>() != null) {
            if (!gameOver) {
                collisionCount++;
                collisionText.text = "Total Points: " + collisionCount;
            }
        }
    }

    public void Reset() {
        collisionCount = 0;
        collisionText.text = "Total Points: " + collisionCount;
        gameOver = false;
    }

    public void GameOver() {
        gameOver = true;
    }
}
