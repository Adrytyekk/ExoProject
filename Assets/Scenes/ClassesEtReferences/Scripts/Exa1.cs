using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exa1 : MonoBehaviour
{

    void Start()
    {
        Cat Billy = new Cat("Billy", "Blue", 7);
        Billy.Display();
    }

}

public class Cat
{
    string Name;
    string Color;
    int Weight;

    public Cat(string name, string color, int weight)
    {
        Name = name;
        Color = color;
        Weight = weight;
    }

    public void Display()
    {
        Debug.Log(Name + " is " + Color + " and he's weights is " + Weight + " kilos ");
    }
    
}
