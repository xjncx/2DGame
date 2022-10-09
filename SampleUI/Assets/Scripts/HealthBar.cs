using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

    private float _sliderSmoothVelocity = 200f;
    private float  _currentVelocity = 0.0f;
    private float _currentHealth;

    private void Start()
    {
        _slider.maxValue = _health.Maximum;
        _slider.value = _health.Current;     
    }

    private void Update()
    {
        _currentHealth = Mathf.SmoothDamp(_slider.value, _health.Current, ref _currentVelocity, _sliderSmoothVelocity * Time.deltaTime);
        _slider.value = _currentHealth;
    }
}
