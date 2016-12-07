using UnityEngine;
using System.Collections;

public class cod16 : MonoBehaviour {

	float timeCounter = 0;

	public float speed = 2;
	public float width = 4;
	public float height = 4;
		
	void Update () {
		timeCounter += Time.deltaTime * speed;

		float x = Mathf.Cos(timeCounter * 2) * width;
		float y = Mathf.Sin (timeCounter * 2) * height;
		float z = 0;

		//로컬포지션을 이용하여 부모오브젝트 포지션 값을 기준으로 회전
		transform.localPosition = new Vector3 (x, y, z);
	}
}
