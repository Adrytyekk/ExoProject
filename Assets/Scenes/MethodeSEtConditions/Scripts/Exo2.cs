using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exo2 : MonoBehaviour
{
    public void displayTemperatureFeeling(int waterTemp)
    {
        if (waterTemp < 14)
        {
            Debug.Log("It's too cold");  
        }
        else
        {
            Debug.Log("It's too hot");
        }
    }

    void Start()
    {
        displayTemperatureFeeling(12); 
    }

}
