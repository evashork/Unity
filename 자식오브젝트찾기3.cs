using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class type16 : MonoBehaviour {

    Transform box;


	// Use this for initialization
	void Awake () {
        box = this.transform;

        foreach (Transform t in box){
            t.gameObject.SetActive(false);
        }

        box.GetChild(1).gameObject.SetActive(true);
	}
}
