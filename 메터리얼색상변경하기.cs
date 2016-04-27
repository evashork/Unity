using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Unity5

public class GS : MonoBehaviour {
    

	GameObject boneColor;
	GameObject goldnum;

	void Awake () {
		boneColor = GameObject.Find ("bone_color");
		goldnum = GameObject.Find ("gold_num");
		
		// 다른 오브젝트에서 색상팔레트로 색상을 지정 후 rgb 색상 값을 가져온다.
    print (goldnum.GetComponent<TextMesh> ().color);
    
		Material material = boneColor.GetComponent<Renderer> ().material;
		material.color = new Vector4 (1f, 0.859f, 0.255f, 1f);
	}
}
