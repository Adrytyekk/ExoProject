using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningComponent : MonoBehaviour
{
    public bool IsSpinning;

    void FixedUpdate()
    {
        if(IsSpinning = true)
        {
            transform.Rotate(0, 10, 0, Space.Self);
        }
    }
}
