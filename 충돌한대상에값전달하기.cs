//script for 총알

void OnTriggerEnter(Collider col)

{

 GameObject player = col.gameObject// 맞은 플레이어는 col로 받아들여진다. col.gameObject 를 통해 해당 플레이어의 게임 오브젝트를 player에 저장한다.

 State Script = player.GetComponent<State>();

 Script.IsDead(); //플레이어의 상태가 죽음으로 바뀜

}
