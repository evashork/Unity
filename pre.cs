using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	void Start () {
		GameObject prefab = Resources.Load("Name") as GameObject;
		for (int i = 0; i < 100; i++) {
			GameObject go = Instantiate(prefab) as GameObject;
			go.transform.position = new Vector3 (0, i*5, 0);
		}
	}
}
