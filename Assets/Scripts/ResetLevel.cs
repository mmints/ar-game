using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour {

    public Rigidbody ball;
    public GameObject spawnPoint;

    public Text gameOverText;
    public Text collisionText;

    private Color fontColor = new Color32(0x55, 0x55, 0x55, 0xFF);

    public void Reset() {
        var ballTransform = ball.transform;
        var spawnTransform = spawnPoint.transform;
        ballTransform.position = spawnTransform.position;
        ball.angularVelocity = Vector3.zero;
        ball.velocity = Vector3.zero;

        var collisionComponent = ball.GetComponent<BallCollisions>();
        if (collisionComponent != null) {
            collisionComponent.Reset();
        }
        gameOverText.text = string.Empty;
        collisionText.color = fontColor;
    }
}
