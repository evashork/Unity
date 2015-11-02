using UnityEngine;
using System.Collections;
using System.Collections.Generic; // list 

public class list : MonoBehaviour {

	List<GameObject> boxList = new List<GameObject>();

	Transform box;

	void Awake() {
		box = GameObject.Find ("Box").transform;
	}
	
	void Start () {
		foreach(Transform boxIn in box){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			boxList.Add(boxIn.gameObject);
			boxIn.gameObject.SetActive(false);
			//print(boxList[0]);
		}

		// 함수화
		ListUp (box, boxList);
		ListUp (box2, boxList2);
	}

	// 함수화
	void ListUp(Transform boxIn, List<GameObject> boxListSet){

		foreach(Transform boxOut in boxIn){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			boxListSet.Add(boxIn.gameObject);
			boxOut.gameObject.SetActive(false);
		}

	}
}
