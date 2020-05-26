using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVolume : MonoBehaviour {

	public Animator animator;

	private void OnTriggerEnter(Collider other) {
		animator.SetBool("PlayAnim", true);
		Debug.Log(other.name);
	}

	private void OnTriggerExit(Collider other) {
		animator.SetBool("PlayAnim", false);
	}
}
