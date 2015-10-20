using UnityEngine;
using System.Collections;

public class AnimationChange : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.LeftArrow)){ 

			GetComponent<Animation>().CrossFade("walk");

		}else{

			GetComponent<Animation>().CrossFade("idle");

		}
	}
}
