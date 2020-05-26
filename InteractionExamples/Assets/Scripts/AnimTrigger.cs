using UnityEngine;
using System.Collections;
[RequireComponent(typeof (Animator))]

public class AnimTrigger : MonoBehaviour {
	
	public Animator anim;
	public bool trigger = false;
	public float delay = 0;

	void Update () {
		if(trigger && Time.time > delay){
			anim.Play(0);
			trigger = false;
		}
	}

}
