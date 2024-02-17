using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private enum Mode
    {

    }

    private void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
    }
}
