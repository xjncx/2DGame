using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maximum;
    [SerializeField] private float _current;

    public float Maximum => _maximum;
    public float Current => _current;

    public void IncreaseHealth(float points)
    {
        _current += points;
    }

    public void DecreaseHealth(float points)
    {
        _current -= points;
    }
}
