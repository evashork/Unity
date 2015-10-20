using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed = 3f;

	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.RightArrow)){ 

			transform.Translate (0, 0, speed * Time.deltaTime);
		
		}else if(Input.GetKey(KeyCode.DownArrow)){

			transform.Translate (0, 0, -speed * Time.deltaTime);
		
		}
	}
}
