using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover2 : MonoBehaviour {

    public float spread = 1f;
    public float speed = 0.1f;
    public float fps = 12f;

    private Vector3 target = Vector3.zero;
    private float fpsCounter = 0f;

	void Start () {
        fps = 1f / fps;
        pickTarget();
	}
	
	void Update () {
        fpsCounter += Time.deltaTime;
        if (fpsCounter >= fps) {
            transform.position = Vector3.Lerp(transform.position, target, Random.Range(speed * 0.1f, speed));

            if (Vector3.Distance(transform.position, target) < 0.1f) {
                pickTarget();
            }

            fpsCounter = 0f;
        }
	}

    void pickTarget() {
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);
        float z = Random.Range(-spread, spread);

        target = new Vector3(x, y, z);
        Debug.Log(target);
    }

}
