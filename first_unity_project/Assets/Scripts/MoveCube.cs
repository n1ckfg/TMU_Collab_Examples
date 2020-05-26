using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    public float yDelta = 0f;
    public float yRot = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, yDelta, 0f);
        transform.Rotate(0f, yRot, 0f);
	}
}
