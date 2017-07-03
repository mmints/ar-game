using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour {

    void Update() {
        if (Input.GetAxis("Reload") == 1) {
            SceneManager.LoadScene("primitiveFlipper");
        }
    }

    void ReloadOnTouch() {
        SceneManager.LoadScene("primitiveFlipper");
    }
}
