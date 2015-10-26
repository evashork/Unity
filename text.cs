using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Unity5

public class text : MonoBehaviour {

	public int point;

	public Text pointText;
	
	// Update is called once per frame
	void Update () {
		point ++;
		pointText.GetComponent<Text> ().text = point.ToString ();
	}
}
