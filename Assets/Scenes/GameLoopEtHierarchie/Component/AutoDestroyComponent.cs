using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyComponent : MonoBehaviour
{

    public float TimeBeforeDestroy = 2.0f;

    void Start()
    {
        Invoke("DestroyThis", TimeBeforeDestroy);
    }

    void Update()
    {
        
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }

}
