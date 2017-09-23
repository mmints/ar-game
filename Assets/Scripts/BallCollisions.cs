using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollisions : MonoBehaviour {

    public int collisionCount;
    public Text collisionText;
	TextMesh textObj;

    private bool gameOver;

    void Start() {
        collisionCount = 0;
		textObj = GameObject.Find("Score3D").GetComponent<TextMesh>();
		textObj.text = collisionCount.ToString();
    }

    void OnCollisionEnter(Collision hit) {
        if (hit.gameObject.GetComponent<PointEvent>() != null) {
            if (!gameOver) {
                collisionCount++;
                collisionText.text = "Total Points: " + collisionCount;
				textObj.text = collisionCount.ToString();
            }
        }
    }

    public void Reset() {
        collisionCount = 0;
        collisionText.text = "Total Points: " + collisionCount;
		textObj.text = collisionCount.ToString();
        gameOver = false;
    }

    public void GameOver() {
        gameOver = true;
    }
}
