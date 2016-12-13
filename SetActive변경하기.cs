using UnityEngine;
using System.Collections;

public class KeyInput : MonoBehaviour {

	void SetActiveTrue(){
    this.gameObject.SetActive(!this.gameObject.activeSelf); // 현재 오브젝트의 반대 값을 입력한다.
  }
}
