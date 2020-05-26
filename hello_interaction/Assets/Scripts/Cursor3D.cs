using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor3D : MonoBehaviour {

	public BasicController ctl;

	private Renderer ren;

	private void Awake() {
		ren = GetComponent<Renderer>();
		ren.enabled = false;
	}

	void Update () {
		ren.enabled = ctl.isDrawing;

		if (ctl.isDrawing) {
			transform.position = ctl.lastHitPos;
		}
	}

}
