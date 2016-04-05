private Vector3 gridTransform;
private float gridMoveSpeed = 5.0f; //그리드 이동시 속도
private float gridMoveDistance = 0.5f;  //그리드 이동거리
private bool gridCanMove = true;    //그리드 이동이 가능한가?
private bool gridMoveDelay = false; //이동버튼을 누르고 있을때 그리드 이동후 잠시 멈추는 효과를 주기위한 변수
private float gridMoveDelayTime = 0.05f;    //이동버튼을 누르고 있을때 그리드 이동시 잠시 멈춤효과 시간
 
void Start()
{
    gridTransform = transform.position;
}
 
void FixedUpdate() {
    float hori_raw = Input.GetAxisRaw(horizontal);
    float ver_raw = Input.GetAxisRaw(vertical);
     
    if (gridTransform == transform.position)
    {
        if (gridCanMove == true)
        {
            if (hori_raw == 1)
            {
                gridTransform += Vector3.right * gridMoveDistance;
            }
            if (hori_raw == -1)
            {
                gridTransform += Vector3.left * gridMoveDistance;
            }
            if (ver_raw == -1)
            {
                gridTransform += Vector3.up * gridMoveDistance;
            }
            if (ver_raw == 1)
            {
                gridTransform += Vector3.down * gridMoveDistance;
            }
            gridCanMove = false;
 
        }
        else
        {
            if (gridMoveDelay == false)
            {
                gridMoveDelay = true;
                StartCoroutine("GridMoveDelay");
            }
        }
    }
    else
    {
        transform.position = Vector3.MoveTowards(transform.position, gridTransform, Time.deltaTime * gridMoveSpeed);    // Move there
    }
}
 
IEnumerator GridMoveDelay()
{
    yield return new WaitForSeconds(gridMoveDelayTime);
    gridCanMove = true;
    gridMoveDelay = false;
}
