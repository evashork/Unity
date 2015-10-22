using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

	public AudioClip snd;

	// Use this for initialization
	void Start () {
		SoundStart ();
	}
	
	// Update is called once per frame
	public void  SoundStart() {
		GetComponent<AudioSource> ().PlayOneShot (snd);
	}
}
