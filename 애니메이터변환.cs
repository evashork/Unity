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

 
