using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMarker : MonoBehaviour {

    public List<Button> buttons;

    private bool loading = false;

    public void OnMarkerFound(ARMarker marker) {
        if (marker.Tag != null && !loading) {
            if (SceneManager.GetSceneByName(marker.Tag) != null) {
                SceneManager.LoadSceneAsync(marker.Tag);

                loading = true;
                if (buttons != null) {
                    foreach (var button in buttons) {
                        var comButton = button.GetComponent<LoadScene>();
                        if (comButton != null) {
                            if (comButton.sceneName == marker.Tag) {
                                var comImage = button.GetComponent<Image>();
                                if (comImage != null)
                                    comImage.color = Color.gray;
                            } else {
                                button.enabled = false;
                            }
                        }
                    }
                }
            }
        }
    }

}
