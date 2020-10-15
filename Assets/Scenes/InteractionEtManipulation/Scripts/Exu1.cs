using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exu1 : MonoBehaviour
{

    public Color LeftClickColor;
    public Color RightClickColor;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            LeftClickColor = gameObject.GetComponent<MeshRenderer>().material.color;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            RightClickColor = gameObject.GetComponent<MeshRenderer>().material.color;
        }

    }
}
