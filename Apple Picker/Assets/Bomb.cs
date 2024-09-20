using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
    public static float     bottemY = -20f;

    void Update () {
        if (transform.position.y < bottemY) {
            Destroy( this.gameObject );

        }
    }

}
