using UnityEngine;
using System.Collections;

public class PlayerMain : MonoBehaviour {

	
	// trigger가 체크 된  상태에서는 충돌 위치를 파악 할 수 없다

	// 3D
	void OnCollisionEnter(Collision col){
		Vector3 pos = col.contacts [0].point;
		print (pos);
	}

	// 2D
	void OnCollisionEnter2D(Collision2D col){
		Vector3 pos = col.contacts [0].point;
		print (pos);
	}



}
