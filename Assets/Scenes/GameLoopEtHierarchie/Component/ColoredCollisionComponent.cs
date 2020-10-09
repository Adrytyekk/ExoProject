using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredCollisionComponent : MonoBehaviour
{

    public Color CollisionColor;
    Color _baseColor;

    void Start()
    {
        
    }

    void Awake()
    {
        _baseColor = GetComponent<MeshRenderer>().material.color; 
    }

    void OnTriggerEnter(Collider other)
    {
        CollisionColor = GetComponent<MeshRenderer>().material.color;
    }

    void OnTriggerExit(Collider other)
    {
        _baseColor = GetComponent<MeshRenderer>().material.color;
    }

    void Update()
    {
        
    }
}
