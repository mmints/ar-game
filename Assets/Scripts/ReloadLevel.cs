using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour {

    void Update() {
        if (Input.GetAxis("Reload") == 1) {
            SceneManager.LoadScene("toyFlipper");
        }
    }

    void ReloadOnTouch() {
        SceneManager.LoadScene("toyFlipper");
    }
}
