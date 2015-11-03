using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class list2 : MonoBehaviour {

	List<GameObject> boxList = new List<GameObject>(); // 리스트선언 
	Transform box; // 부모 자식관계 찾기

	void Awake(){
		box = transform.FindChild("Box"); // 부모 찾기
	}

	// Use this for initialization
	void Start () {
		ListUp(box, boxList); // 배열 담는 함수 실행, 인자전달  
		ShowList(boxList, 1); // 선택한 아이템을 활성화
	}
	
	// 리스트를 만들고 아이템을 비활성화
	void ListUp (Transform boxIn, List<GameObject> boxListSet) {
		
		foreach (Transform boxOut in boxIn) // 리스트에 아이템 집어넣기
		{
			boxListSet.Add(boxOut.gameObject); // 리스트에 아이템 추가
			boxOut.gameObject.SetActive(false); // 아이템 비활성화
		}
	}
	
	// 선택한 아이템을 활성화
	void ShowList (List<GameObject> itemList, int itemNum){
		for(int i = 0; i < itemList.Count; i++){
			itemList[i].SetActive(false);  // 아이템을 비활성화
			print(itemList.Count);
			print(itemList[i]);
		}
		
		
		itemList[itemNum].SetActive(true);
	}
}
