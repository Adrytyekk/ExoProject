using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    void Start()
    {
        int five = 5;
        int seven = 7;
        bool fiveIsGreaterThanSeven;
        fiveIsGreaterThanSeven = five > seven;
        bool fiveIsLesserThanSeven;
        fiveIsLesserThanSeven = five < seven;
        bool sevenIsGreaterThanFive;
        sevenIsGreaterThanFive = seven > five;
        bool sevenIsLesserThanFive;
        sevenIsLesserThanFive = seven < five;
        bool fiveIsEqualToFive;
        fiveIsEqualToFive = five == five;
        bool sevenIsNotEqualToSeven;
        sevenIsNotEqualToSeven = seven != seven;

        Debug.Log(fiveIsGreaterThanSeven);
        Debug.Log(fiveIsLesserThanSeven);
        Debug.Log(sevenIsGreaterThanFive);
        Debug.Log(sevenIsLesserThanFive);
        Debug.Log(fiveIsEqualToFive);
        Debug.Log(sevenIsNotEqualToSeven);
    }

}
