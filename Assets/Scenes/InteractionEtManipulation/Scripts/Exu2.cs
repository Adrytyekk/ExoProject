using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exu2 : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(x: Input.GetAxis("Mouse Y"), y: Input.GetAxis("Mouse X"), z: 0);

    }
}
