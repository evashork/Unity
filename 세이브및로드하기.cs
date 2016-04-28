using UnityEngine;
using System.Collections;

public class save : MonoBehaviour {

	int moneyNum;
	string moneyType;

	void Save(){
		PlayerPrefs.SetInt ("money",moneyNum);  // "키값",데이터
		PlayerPrefs.SetString ("moneyType",moneyType);  // "키값",데이터
	}

	void Load(){
		moneyNum = PlayerPrefs.GetInt ("money");
		moneyType = PlayerPrefs.GetString ("moneyType");
	}

	// 저장 데이터가 있는지 체크
	void LoadCheck(){
		if (PlayerPrefs.GetInt ("money") != null)
			Load ();
		else
			Save ();
	}
}
