using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exe2 : MonoBehaviour
{

    void Awake()
    {
        Debug.Log(" I'm awake ! ");
    }

    void Start()
    {
        Debug.Log(" I Start ! ");
    }

    void OnEnable()
    {
        Debug.Log(" I'm Enabled ! ");
    }

    void OnDisable()
    {
        Debug.Log(" I'm Disabled ! ");
    }

    void OnDestroy()
    {
        Debug.Log(" I'm Destroyed ! ");
    }

    void Update()
    {

    }

}
