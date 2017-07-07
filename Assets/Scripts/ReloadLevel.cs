using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour {

    void ReloadOnTouch() {
        // FIXME: respawn ball instead, how it should be..
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
