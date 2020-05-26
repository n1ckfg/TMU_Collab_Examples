using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocation2 : MonoBehaviour {

	public BasicController ctl;
	public float speed = 0f;
	public float delta = 0.0001f;
	public Vector3 offset = new Vector3(0f, 0.5f, 0f);

	[HideInInspector] public Vector3 target;

	private Vector3 origPos;
	private bool isMoving = false;

	void Start() {
		origPos = transform.position;
	}

	void Update()
	{
		if (ctl.isDrawing) {
			target = ctl.lastHitPos;
			speed += delta;
		} else {
			if (speed > 0f) {
				speed -= delta;
			} else if (speed < 0f) {
				speed = 0f;
			}
		}

		if (Input.GetKeyDown(KeyCode.R)) { // reset
			transform.position = origPos;
			speed = 0f;
		}

		Vector3 newPos = Vector3.Lerp(transform.position, target, speed);
		transform.position = new Vector3(newPos.x, origPos.y, newPos.z);
	}



}
