using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject player;

	public float offsetX = 14f;
	public float offsetY = 10f;
	public float offsetZ = 14f;

	public float followSpeed = 15f;

	Vector3 cameraPosition;
	
	// Update is called once per frame
	void LateUpdate () {
		cameraPosition.x = player.transform.position.x + offsetX;
		cameraPosition.y = player.transform.position.y + offsetY;
		cameraPosition.z = player.transform.position.z + offsetZ;

		transform.position = cameraPosition;
		//transform.position = Vector3.Lerp (transform.position, cameraPosition, followSpeed * Time.deltaTime);
	}
}
