using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
    void ApplyDamage(float damage) {
        print(damage);
    }
    void Example() {
        SendMessage("ApplyDamage", 5.0F);
    }
}


// 인자는 하나밖에 전달 할 수 없다.
