int aniNumber = 0;
Animator anim;

// Use this for initialization
void Start () {
   anim = GetComponent<Animator>();
}
	
public void ChangAni(){
    aniNumber = 1;
    anim.SetInteger("regen", aniNumber ); 
}
    
public void StopAni(){
    aniNumber = 0;
    anim.SetInteger("regen", aniNumber ); 
}

// 애니메이터에 파라미터 값을 설정하여 애니메이션을 변환한다.
// 화살표에 조건값을 준다.

 
