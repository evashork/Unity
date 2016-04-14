using UnityEngine;
using System.Collections;
using System.Collections.Generic; // list 
public class deathEffect: MonoBehaviour {

	List<GameObject> boxList = new List<GameObject>();
	Transform box; 
	// Use this for initialization
	void Start () {
		box = this.transform;
    
    // list에 자식을 찾아서 담기
		foreach(Transform boxIn in box){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			boxList.Add(boxIn.gameObject);
			boxIn.gameObject.SetActive(false);
			print(boxList[0]);
		}

		Shot();
	}
  
  // list 안에 있는 자식들에게 명령실행
	void Shot(){
		foreach(GameObject boxIn in boxList){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			boxIn.gameObject.SetActive(true);
			boxIn.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(480.0f, 480.0f, 0.0f));
		}
	}
}
