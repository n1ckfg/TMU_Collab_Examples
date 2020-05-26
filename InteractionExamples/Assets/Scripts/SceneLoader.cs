using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour {

	public string levelName = "Main_no_AR";

	private AsyncOperation async;

	IEnumerator Start() {
		async = Application.LoadLevelAsync(levelName);
		async.allowSceneActivation = false;

		yield return async;
	}
	
	public void sceneActivate() {
		async.allowSceneActivation = true;
	}

}
