using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

    public Transform target;
    public bool alwaysUpdate = true;

    private bool firstRun = true;

    private void Update() {
        if (firstRun || alwaysUpdate) {
            transform.LookAt(target);
            firstRun = false;
        }
    }

}