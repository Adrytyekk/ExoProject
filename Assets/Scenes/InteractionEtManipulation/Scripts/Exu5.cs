using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exu5 : MonoBehaviour
{

    public int Speed = 100;
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float mouseYValue = Input.GetAxis("Mouse Y") * Speed;
        transform.Rotate(mouseYValue * Time.deltaTime, 0, 0 );
    }
}
