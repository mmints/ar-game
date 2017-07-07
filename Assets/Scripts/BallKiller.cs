using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BallKiller : MonoBehaviour {

    public Text gameOverText;
    public Text collisionText;

    void OnTriggerEnter(Collider other) {
        var gameObject = other.gameObject;
	    if (gameObject.name == "Ball") {
	        Debug.Log(gameObject.name + " was killed!");
	        Destroy(gameObject);
	        gameOverText.text = "Game Over!";
	        collisionText.color = Color.red;
	    }
    }
}
