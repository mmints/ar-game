using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour {

    public Rigidbody ball;
    public GameObject spawnPoint;

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
        var accelComponent = ball.GetComponent<AccelerometerController>();
        if (accelComponent != null) {
            accelComponent.Reset();
        }
    }
}
