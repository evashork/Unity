using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopGS : MonoBehaviour {

    public Transform mario;
	
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                if (hit.collider != null)
                {
                    SelectChr(hit.collider.name);
                }
            }
        }
    }

    void SelectChr(string chrName)
    {
        for (int i = 0; i < mario.childCount; i++){
            if(chrName == mario.transform.GetChild(i).name) {
                mario.transform.GetChild(i).gameObject.SetActive(true);
            }else{
                mario.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
