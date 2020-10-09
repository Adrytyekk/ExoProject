using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exo5 : MonoBehaviour
{
    public int Days = 1;
    public int Weeks = 1;
    public int Months = 1;
    public int Years = 1;
    public float TimeScale = 0.1f;
    float DayTime = 0f;
    float WeekTime = 1f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        DayTime += TimeScale;
        WeekTime += TimeScale;

        if (DayTime >= 1)
        {
            ++Days;
            DayTime = 0f;
        }

        if (WeekTime >= 8)
        {
            ++Weeks;
            WeekTime = 1f;
        }

        if(Days >= 31)
        {
            ++Months;
            Days = 1;
        }

        if (Months >= 13)
        {
            ++Years;
            Months = 1;
        }
    }
}
