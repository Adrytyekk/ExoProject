using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exu4 : MonoBehaviour
{

    public int Speed = 100;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float mouseXValue = Input.GetAxis("Mouse X") * Speed;
        transform.Rotate(0, mouseXValue * Time.deltaTime, 0);
    }
}
