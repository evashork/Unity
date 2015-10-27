using UnityEngine;
using System.Collections;

public class PointMGscript : MonoBehaviour {

	public int point;
	
	// PointMG 오브젝트의 컴포넌트인 PointMGscript 스크립트 속 퍼블릭 함수에 접근

	void Update () {

		GameObject.Find("PointMG").GetComponent<PointMGscript>().UpdatePoint(); 

	}
}
