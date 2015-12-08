using UnityEngine;
using System.Collections;

public class PlayerMain : MonoBehaviour {

	GameObject player;   // 오브젝트 가져오기
	GameObject[] deathzone; // 여러개의 오브젝트 가져오기

	void Awake(){   // 캐시 설정
		player = GameObject.FindGameObjectWithTag ("Player");  // 태그로 오브젝트 찾기
		deathzone = GameObject.FindGameObjectsWithTag ("deathzone"); // 태그로 다수의 오브젝트 찾기

		player.GetComponent<SpriteRenderer>().enabled = false;  // 컴포넌트를 비활성화

		foreach(GameObject deathzoneEach in deathzone){  // 다수의 오브젝트 컴포넌트를 각각 비활성화
			deathzoneEach.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
