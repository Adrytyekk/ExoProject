using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exa4 : MonoBehaviour
{

    private GameObject _createdCube;

    void Start()
    {
        InvokeRepeating("CreateSpinningCube", 0, 2);
    }

    void DestroyCube()
    {
        Destroy(_createdCube);
    }

    void CreateSpinningCube()
    {
        _createdCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        _createdCube.AddComponent<Rigidbody>();
        _createdCube.AddComponent<SpinningComponent>().IsSpinning = true;
        Invoke("DestroyCube", 1);
    }

}
