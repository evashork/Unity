using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed = 3f;

	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, speed * Time.deltaTime);
	}
}
