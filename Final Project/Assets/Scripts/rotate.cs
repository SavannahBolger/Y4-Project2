using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    public float newYAngle;
    public float oldYAngle;
    public float newXAngle;
    public float oldXAngle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StopAllCoroutines();
            newYAngle = oldYAngle - 90f;
            StartCoroutine(Rotate(newXAngle,newYAngle));
            oldYAngle = newYAngle;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StopAllCoroutines();
            newYAngle = oldYAngle + 90f;
            StartCoroutine(Rotate(newXAngle,newYAngle));
            oldYAngle = newYAngle;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StopAllCoroutines();
            newXAngle = oldYAngle + 90f;
            StartCoroutine(Rotate(newXAngle, newYAngle));
            oldYAngle = newXAngle;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StopAllCoroutines();
            newXAngle = oldXAngle - 90f;
            StartCoroutine(Rotate(newXAngle, newYAngle));
            oldXAngle = newXAngle;
        }
    }

    IEnumerator Rotate(float targetAngleX, float targetAngleY)
    {
        while (transform.rotation.y != targetAngleY || transform.rotation.x != targetAngleX)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetAngleX, targetAngleY, 0f), 3f * Time.deltaTime);
            yield return null;
        }
        transform.rotation = Quaternion.Euler(targetAngleX, targetAngleY, 0f);
        yield return null;
    }
}
