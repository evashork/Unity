// 데이터 저장하기

void SaveS(){
  PlayerPrefs.SetInt("키이름",값);
  PlayerPrefs.SetString("키이름", 값);
}


// 데이터 불러오기

void LoadL(){
  Num = PlayerPrefs.GetInt("키이름");
  Name = PlayerPrefs.GetString("키이름");
}
