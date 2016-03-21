// player 오브젝트
// 버튼에 연동
public void Save () {

}

// manager 오브젝트

public void GotoScene() {
  GameObject boy = GameObject.Find("player");
  boy.GetComponent<playerScript>().Save(); // <스크립트 이름>
  Application.LoadLevel("start");
}
