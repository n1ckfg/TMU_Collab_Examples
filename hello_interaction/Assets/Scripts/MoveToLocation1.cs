using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocation1 : MonoBehaviour {

	public BasicController ctl;
	public Transform target;
	public float speed = 0f;
	public float delta = 0.0001f;

	private Vector3 origPos;
	private bool isMoving = false;

	void Start() {
		origPos = transform.position;
	}

	void Update() {
		if (ctl.clicked && ctl.isLookingAt == gameObject.name) {
			isMoving = true;
		} else if (!ctl.isDrawing) {
			isMoving = false;
		}

		if (isMoving) {
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

		Vector3 newPos = Vector3.Lerp(transform.position, target.position, speed);
		transform.position = new Vector3(newPos.x, origPos.y, newPos.z);
	}



}
