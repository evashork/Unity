using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
    void ApplyDamage(float damage) {
        print(damage);
    }
    void Example() {
        SendMessage("ApplyDamage", 5.0F);
    }

    void OnTriggerEnter(Collider coll)
	{
		coll.SendMessage("ApplyDamage", 5.0F, SendMessageOptions.DontRequireReceiver);
	}
	
	GameObject.Find("Box").SendMessage("Method", 1.0f);
}


// 인자는 하나밖에 전달 할 수 없다.
