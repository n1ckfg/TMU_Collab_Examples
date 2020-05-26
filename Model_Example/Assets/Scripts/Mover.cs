using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed = 1f;

	void Update () {
        transform.Translate(0f, 0f, speed);
	}

}
