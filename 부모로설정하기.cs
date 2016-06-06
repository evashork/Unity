using UnityEngine;
using System.Collections;

public class SetParent : MonoBehaviour {

	GameObject player;

	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){

		if(col.gameObject == player){
			print ("Enter");
			player.transform.SetParent(this.transform);
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject == player){
			print ("Exit");
			transform.DetachChildren();
		}
	}
}
