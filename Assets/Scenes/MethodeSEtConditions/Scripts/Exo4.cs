using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exo4 : MonoBehaviour
{
    public int MyAge;
    public string MyName;
    bool BuyAlcoolInUsa;
    bool BuyAlcoolInFrance;

    void CanIBuyAlcool()
    {
        if(MyAge >= 21)
        {
            BuyAlcoolInUsa = true;
        }
        else
        {
            BuyAlcoolInUsa = false;
        }

        if (MyAge >= 18)
        {
            BuyAlcoolInFrance = true;
        }
        else
        {
            BuyAlcoolInFrance = false;
        }
    }

    void Start()
    {
        CanIBuyAlcool();
        Debug.Log(MyAge);
        Debug.Log(MyName);
        Debug.Log(BuyAlcoolInUsa);
        Debug.Log(BuyAlcoolInFrance);
    }

}
