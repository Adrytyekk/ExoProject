using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6 : MonoBehaviour
{
    void Start()
    {
        bool isCatAlive = false;
        bool isMouseAlive;
        isMouseAlive = !isCatAlive;
        bool isSomeoneAlive;
        isSomeoneAlive = isCatAlive || isMouseAlive;
        bool isEveryoneAlive;
        isEveryoneAlive = isCatAlive && isMouseAlive;
        Debug.Log(isCatAlive);
        Debug.Log(isMouseAlive);
        Debug.Log(isSomeoneAlive);
        Debug.Log(isEveryoneAlive);
    }

}
