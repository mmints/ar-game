using UnityEngine;
using System.Collections;

public class ReloadLevel : MonoBehaviour {

	void OnGUI() {
		GUILayout.Label("Press R To Restart" + "\n");
		//if (Event.current.Equals (Event.KeyboardEvent ("r"))) {
		if (Input.GetAxis("Reload") == 1) {
			Application.LoadLevel("primitiveFlipper");
		}

	}
}
