using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform trackingObject;

    void Update()
    {
        transform.position = new Vector3(trackingObject.position.x, trackingObject.position.y, transform.position.z);
    }
}
