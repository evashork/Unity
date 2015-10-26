using UnityEngine;
using System.Collections;

public class text2 : MonoBehaviour {

	public int point = 3;

	public GUIText pointText;

	
	// Update is called once per frame
	void Update () {
		pointText.text = point.ToString ();	
	}
}
