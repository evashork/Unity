using UnityEngine;
using System.Collections;

public class missile : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject);
		Destroy (this.gameObject, 2.0f);
	}
}
