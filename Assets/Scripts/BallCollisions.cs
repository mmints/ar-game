using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollisions : MonoBehaviour {

    public TextMesh score3D;

    private int points;
    private bool gameOver;

    void Start() {
        points = 0;
        updateText();
    }

    void OnCollisionEnter(Collision hit) {
        if (!gameOver) {
            var com = hit.gameObject.GetComponent<PointEvent>();
            if (com != null) {
                ++points;
                updateText();
            }
        }
    }

    public void Reset() {
        points = 0;
        gameOver = false;
        updateText();
    }

    public void GameOver() {
        gameOver = true;
        updateText();
    }

    private void updateText() {
        if (gameOver) {
            score3D.color = Color.red;
            score3D.fontSize = 70;
            score3D.text = "Game Over!\n" +
                "Score: " + points;
        } else {
            score3D.color = Color.white;
            score3D.fontSize = 100;
            score3D.text = "Points: " + points;
        }
    }
}
