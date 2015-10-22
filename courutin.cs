using UnityEngine;
using System.Collections;

public class mgmissile : MonoBehaviour {


	public GameObject missile;
	public GameObject missilePoint;
	public float missileTime = 0.2f;

	// Use this for initialization
	void Start () {
		StartCoroutine (MgMissile ());
	}

	IEnumerator MgMissile(){
		MakeMissile ();

		yield return new WaitForSeconds (missileTime);

		StartCoroutine (MgMissile ());
	}

	void MakeMissile(){
		Instantiate (missile, missilePoint.transform.position, missilePoint.transform.rotation);
	}
}
