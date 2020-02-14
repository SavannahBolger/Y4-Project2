using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    public float x = 0.0f;
    public float z = 0.0f;

    void Start()
    {

    }

    void Update()
    {
        x = transform.rotation.x * 100;
        z = transform.rotation.z * 100;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (z > -34.0f)
            {
                transform.Rotate(0, 0, -1);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (z < 34.0f)
            {
                transform.Rotate(0, 0, 1);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (x < 34.0f)
            {
                transform.Rotate(1, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (x > -34.0f)
            {
                transform.Rotate(-1, 0, 0);
            }
        }
    }

}
