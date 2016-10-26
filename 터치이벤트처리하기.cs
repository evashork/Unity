using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Unity5
using UnityEngine.SceneManagement;

// 터치 이벤트 UI 제외 하는 법 http://prosto.tistory.com/97

public class chrGS : MonoBehaviour {

	int maxStage;
	int chrBuy;

	float swipeDistanceOk = 20;
	Vector3 StartPosition = Vector3.zero;
	float swipeDistane = 0;
	bool swipedHorizontal = false;
	float _dx = 0;
	float _dy = 0;
  
	void Update(){
		if (Input.GetMouseButtonDown (0)) {    // 터치 시작
      // 터치시작점 저장
			StartPosition = Input.mousePosition;
      
      // 원하는 위치에 터치를 감지
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 1000, 1 << LayerMask.NameToLayer ("areabtn"))) {
				chrBuy = hit.transform.GetChild (1).GetComponent<selectbtn> ().chr_no;
				hit.transform.GetChild (1).GetComponent<selectbtn> ().BuyChr (chrBuy);
			} 
		} else if (Input.GetMouseButton (0)) {     // 터치 진행
			_dx = StartPosition.x - Input.mousePosition.x;
			_dy = StartPosition.y - Input.mousePosition.y;
			swipeDistane = Mathf.Sqrt (Mathf.Pow (_dx, 2) + Mathf.Pow (_dy, 2));
			swipedHorizontal = Mathf.Abs (_dx) > Mathf.Abs (_dy);
		} else if (Input.GetMouseButtonUp (0)) {   // 터치 종료
			//print ("swipeDistane : " + swipeDistane);
			//print (swipedHorizontal);
			if (swipeDistane > swipeDistanceOk) {
				if (swipedHorizontal && _dx > 0) {
					print ("left");
				} else if (swipedHorizontal && _dx < 0) {
					print ("right");
				} else if (!swipedHorizontal && _dy > 0) {
					print ("down");
				} else if (!swipedHorizontal && _dy < 0) {
					print ("up");
				}
			}

			_dx = 0;
			_dx = 0;
			StartPosition = Vector3.zero;
		}
	}
}

