using UnityEngine;
using System.Collections;

public class mgmissile : MonoBehaviour {


	public Vector3 topPosition;
  public Vector3 bottomPosition;
  float speed;

	// Use this for initialization
	void Start () {
		StartCoroutine (Move (topPosition));
	}

	IEnumerator Move(Vector3 target){
		
    // 경우 1
    while(Mathf.Abs((target - transfomr.location).y) > 0.2f){
      Vector3 dir = target.y == topPositon.y ? Vector3.up : Vector3.down;
      transform.localPosition += dir * Time.delatTime * speed;
      
      yield return null;
    }
		
    // 경우 2
    yield return new WaitForSeconds(0.5f);
    
    Vector3 newTarget = (target.y == topPosition.y) ? bottomPosition : topPosition;
    StartCoroutine (Move (newTarget))
	}

	void MakeMissile(){
		Instantiate (missile, missilePoint.transform.position, missilePoint.transform.rotation);
	}
}
