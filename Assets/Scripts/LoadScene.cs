using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public string sceneName;

	public void LoadSynchronous() {
		Debug.Log ("Loading Scene: " + sceneName);
		SceneManager.LoadScene(sceneName);
	}
}
