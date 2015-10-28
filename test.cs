using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public GameObject miniCube;
    public GameObject miniPoint;
    Vector3 shot;

    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Invoke("Tac",1.5f);
        }
    }

    void Tac() {
      GameObject instantItem =  (GameObject)Instantiate(miniCube, miniPoint.transform.position, miniPoint.transform.rotation);
        Rigidbody cubeRig = instantItem.GetComponent<Rigidbody>();
        cubeRig.AddForce(shot * 100f, ForceMode.Impulse);
    }
}
