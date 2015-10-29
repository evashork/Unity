using UnityEngine;
using System.Collections;

public class setactive : MonoBehaviour {

	public GameObject player;
	
	// Update is called once per frame
	void Start () {

		// 게임오브젝트 불러오기 
		player.GetComponent<move> ().speed = 20f; 

		// 게임오브젝트를 이름으로 검색하여 접근하기
		GameObject.Find("PointMG").GetComponent<PointMGscript>().UpdatePoint(); 
	}
}
