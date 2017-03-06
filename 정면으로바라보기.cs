다른 사람의 아이디도 표시되게끔 구현하고싶으시다면, 
캐릭터 Object의 자식Object로 아이디를 입력하는 Text를 넣고, 
해당 Canvas에 LookAtCamera라는 Script를 넣는 방법도 있습니다. 
LookAtCamera 
void Update(){ 
Transform camera=GameObject.Find("MainCamera").transform; 
transform.LookAt(camera.position); 
} 
이렇게 해주시면, 캐릭터 위의 캐릭터이름은 항상 카메라를 바라보게되어, 정면만 보이게됩니다.
