using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exu6 : MonoBehaviour
{

    public int Force = 4;
    
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            GetComponent<Rigidbody>().AddForce(transform.up * Force, ForceMode.Impulse);
        }
    }
}
