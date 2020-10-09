using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exa2 : MonoBehaviour
{

    void Start()
    {
        Car clio = new Car(50, 130);
        clio.Accelerate();
        clio.Accelerate();
        clio.Accelerate();
    }

}

public class Car
{
    int _speed = 0;
    int _power;
    int _maxSpeed;

    public Car(int power, int maxSpeed)
    {
        _power = power;
        _maxSpeed = maxSpeed;
    }

    void CheckMaxSpeed()
    {
        if(_speed >= _maxSpeed)
        {
            _maxSpeed = _speed;
        }
    }

    public void Accelerate()
    {
        _speed += _power;
        CheckMaxSpeed();
        Debug.Log("Vitesse Actuelle " + _speed);
    }

}