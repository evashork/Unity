using UnityEngine;
using System.Collections;

public class mgmissile : MonoBehaviour {


	public GameObject missile;
	public GameObject missilePoint;
	public float missileTime = 0.2f;

	// Use this for initialization
	void Start () {
		// 코루틴 시작하기
		StartCoroutine ("MgMissile" , missileTime);
		// 코루틴 멈추기
		StopCoroutine ("MgMissile");
	}

	IEnumerator MgMissile(float missTime){
		MakeMissile ();

		yield return new WaitForSeconds (missTime);

		StartCoroutine ("MgMissile");
	}

	void MakeMissile(){
		Instantiate (missile, missilePoint.transform.position, missilePoint.transform.rotation);
	}
	
	IEnumerator FadeIn(){
		while(true){
			yield return new WaitForSeconds (2f);
			print ("co!!");
			if (gs.GetComponent<GS> ().GT == GameState.Start) {
				break;
			}
		}
	}
	
}
