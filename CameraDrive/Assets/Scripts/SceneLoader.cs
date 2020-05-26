using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour {

	public string levelName = "Shooter";

	private AsyncOperation async;

	IEnumerator Start() {
		async = Application.LoadLevelAsync(levelName);
		async.allowSceneActivation = false;

		yield return async;
	}

	private void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			sceneActivate();
		}
	}

	public void sceneActivate() {
		async.allowSceneActivation = true;
	}

}
