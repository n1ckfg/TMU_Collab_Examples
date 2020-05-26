using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public float speed = 0.1f;
	public GameObject[] target;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			doStuff();
		}
	}

	void doStuff() {
		for (int i = 0; i < target.Length; i++) {
			target[i].transform.position = Vector3.Lerp(target[i].transform.position, transform.position, speed);
		}
	}

}
