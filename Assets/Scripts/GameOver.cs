using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        var gameObject = other.gameObject;
        if (gameObject.name == "Ball") {
            var collisionComponent = gameObject.GetComponent<BallCollisions>();
            if (collisionComponent != null) {
                collisionComponent.GameOver();
            }
        }
    }
}
