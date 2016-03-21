int aniNumber = 0;

void start () {
  anim = GetComponent<Animator>();
}

public void ChangAni(){
  aniNumber++;
  if(aniNumber > 3)
    aniNumber = 0;
    
  anim.SetInterger("aniNum", aniNumer ); 
}

// 애니메이터에 파라미터 값을 설정하여 애니메이션을 변환한다.
// 화살표에 조건값을 준다.

 
