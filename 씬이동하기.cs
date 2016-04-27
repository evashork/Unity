using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // 추가

public class deathZone : MonoBehaviour {
	void Goal(){
		SceneManager.LoadScene ("stage1");
	}
}
