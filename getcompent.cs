using UnityEngine;
using System.Collections;

public class PlayerMain : MonoBehaviour {

	PlayerController playerCtrl;

	// PlayerController 컴포넌트를 가져와서 캐시에 참조

	void Awake(){   // 캐시 설정
		playerCtrl = GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!playerCtrl.activeSts) {
			return;
		}

		float joyMv = Input.GetAxis("Horizontal");
		playerCtrl.ActionMove (joyMv);

		if(Input.GetButtonDown("Jump")){
			playerCtrl.ActionJump();
		}
	}
}
