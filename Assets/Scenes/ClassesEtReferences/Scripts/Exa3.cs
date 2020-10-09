using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exa3 : MonoBehaviour
{

    void Start()
    {
        Lion butcher = new Lion();
        butcher.Power = 5;
        Gazelle nextMeal = new Gazelle();
        butcher.Attack(nextMeal);
    }

}

public class Gazelle
{
    public int _healthPoints = 2;
    
    public void ReceiveDamage(int damage)
    {
        _healthPoints -= damage;

        if(_healthPoints <= 0)
        {
            Debug.Log("Dinner Time !");
        }
    }

}

public class Lion
{
    public int Power;

    public void Attack(Gazelle gazelle)
    {
        gazelle.ReceiveDamage(Power);
    }
}