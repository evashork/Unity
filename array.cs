using UnityEngine;
using System.Collections;

public class array : MonoBehaviour {

	int[] score = new int[5];

	// Use this for initialization
	void Start () {

		score[0] = 10;
		score[1] = 20;
		score[2] = 30;
		score[3] = 40;
		score[4] = 50;

	}
	
	// Update is called once per frame
	void OnMouseDown () {

		for(int i = 0; i < 5; i++ ){
			print (score[i]);
		}

	}
}
