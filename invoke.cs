using UnityEngine;
using System.Collections;

public class invoke : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("MaterialChange", 0.3f);  // 함수명과 시간
	}
}
