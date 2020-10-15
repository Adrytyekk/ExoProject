using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exu3 : MonoBehaviour
{

    public int Speed = 1;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        float horizontalValue = Input.GetAxis("Horizontal") * Speed;
        float verticalValue = Input.GetAxis("Vertical") * Speed;
        transform.Translate(horizontalValue * Time.deltaTime, 0, verticalValue * Time.deltaTime);
    }
}
