using UnityEngine;
using System.Collections;

public class deathZone : MonoBehaviour {

	public Image codImg;
	codImg.GetComponent<Image> ().sprite = Resources.Load<Sprite>("dieimg/die2");
	// 파일이 반들시 Resources 폴더에 있어야 한다. 
	
}
