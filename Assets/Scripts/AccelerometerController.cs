using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerController : MonoBehaviour {

    private const float COOLDOWN_TIME = 1.0f;

    public bool swapYZ = false;
    public float thresholdLow = -0.15f;
    public float thresholdHigh = 0.15f;
    public Vector3 invertAxis = new Vector3(1, 1, 1);

    public float force;
    public int maxCount;

    private int counter;
    private Rigidbody ball;
    private float lastTilt;
    
    public void Start() {
        counter = 0;
        lastTilt = Time.time;
    }

    public void Update() {
        var ball = GetComponent<Rigidbody>();
        float accX = Input.acceleration.x * Time.deltaTime;
        float accY = Input.acceleration.y * Time.deltaTime;
        float accMax = Mathf.Max(accX, accY);
        float accMin = Mathf.Min(accX, accY);
        if (accMin < thresholdLow || accMax > thresholdHigh &&
              Time.time - lastTilt > COOLDOWN_TIME) {
            if (counter <= maxCount) {
                var x = accX * force * invertAxis.x;
                var y = (swapYZ ? accY * force : 0.0f) * invertAxis.y;
                var z = (swapYZ ? 0.0f : accY * force) * invertAxis.z;
                ball.AddForce(x, y, z, ForceMode.Impulse);
                lastTilt = Time.time;
                ++counter;
            } else {
                // TODO: Tilt Game Over text
                var colComponent = ball.GetComponent<BallCollisions>();
                if (colComponent != null) {
                    colComponent.GameOver();
                }
            }
        }
    }

    public void Reset() {
        counter = 0;
        lastTilt = Time.time;
    }
}
