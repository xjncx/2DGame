using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maximum;
    [SerializeField] private float _current;
    [SerializeField] private float _minimum;
    [SerializeField] private float _points;
    public float Maximum => _maximum;
    public float Current => _current;
    public float Points => _points;
    public void Heal()
    {
        if (_current + _points <= _maximum)
        {
            _current += _points;
        }
        else
        {
            _current = _maximum;
        }

    }

    public void Damage()
    {
        if (_current - _points <= _minimum)
        {
            _current = _minimum;
        }
        else
        {
            _current -= _points;
        }
    }
}
