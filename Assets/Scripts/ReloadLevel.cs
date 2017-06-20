using UnityEngine;
using System.Collections;

public class ReloadLevel : MonoBehaviour {

	void OnGUI() {
		GUILayout.Label("Press R To Restart");
		if (Event.current.Equals(Event.KeyboardEvent("r")))
			Application.LoadLevel("primitiveFlipper");
	}
	// Use this for initialization
}
