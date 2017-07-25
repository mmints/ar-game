using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text gameOverText;
    public Text collisionText;

    void OnTriggerEnter(Collider other) {
        var gameObject = other.gameObject;
        if (gameObject.name == "Ball") {
            gameOverText.text = "Game Over!";
            collisionText.color = Color.red;
            var collisionComponent = gameObject.GetComponent<BallCollisions>();
            if (collisionComponent != null) {
                collisionComponent.GameOver();
            }
        }
    }
}
