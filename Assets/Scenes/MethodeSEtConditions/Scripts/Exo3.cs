using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exo3 : MonoBehaviour
{

    public int getMagicNumber(int a, int b)
    {
        if(a < b)
        {
            return b;
        }

        if(a > b)
        {
            return a - b;
        }

        return 42;
    }

    void Start()
    {
        getMagicNumber(10, 16);
        int magicNumberOne = getMagicNumber(10, 16);
        Debug.Log(magicNumberOne);
        getMagicNumber(20, 5);
        int magicNumberTwo = getMagicNumber(20, 5);
        Debug.Log(magicNumberTwo);
        getMagicNumber(12, 12);
        int magicNumberThree = getMagicNumber(12, 12);
        Debug.Log(magicNumberThree);
    }

}
