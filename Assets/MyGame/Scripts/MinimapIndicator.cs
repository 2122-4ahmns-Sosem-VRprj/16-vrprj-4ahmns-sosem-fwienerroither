using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapIndicator : MonoBehaviour
{
    public Transform cam;

    void Update()
    {
        gameObject.transform.position = new Vector3(cam.position.x,5, cam.position.z);
    }
}
