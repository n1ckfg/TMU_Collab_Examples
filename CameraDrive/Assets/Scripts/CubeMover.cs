using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour {

	public float range = 1f;

	private Vector3 target;

	void Start () {
		target = new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));
	}
	
	void Update () {
		transform.position = Vector3.Lerp(transform.position, target, 0.01f);
	}
}
