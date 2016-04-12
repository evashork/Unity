using UnityEngine;
using System.Collections;
using System.Collections.Generic; // list 
public class deathEffect: MonoBehaviour {

	List<GameObject> boxList = new List<GameObject>();
	Transform box; 
	// Use this for initialization
	void Start () {
		box = this.transform;

		foreach(Transform boxIn in box){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			boxList.Add(boxIn.gameObject);
			boxIn.gameObject.SetActive(false);
			print(boxList[0]);
		}
	}
}
