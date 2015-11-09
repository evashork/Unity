using UnityEngine;
using System.Collections;

public class Material : MonoBehaviour {

	void MaterialChange() {
		Material material = damageEffect.GetComponent<Renderer>().material;  // 컴포넌트 찾아서 메테리얼에 담기
		material.color = Color.white; // 메인 색상을 변경
	}
}
