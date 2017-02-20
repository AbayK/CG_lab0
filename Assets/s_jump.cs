using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_jump : MonoBehaviour {
    float t = 0;
    float x, y, z;
    float y_0;
    float g = -10;
    float v_0 = 10;

    // Use this for initialization
    void Start () {
        x = transform.position.x;
        y_0 = transform.position.y;
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update () {
        t += Time.deltaTime;

        y = y_0 + v_0 * t + g * t * t / 2;
        if (y <= y_0)
        {
            t = 0;
            y = y_0;
        }

        transform.position = new Vector3(x, y, z);

    }
}
