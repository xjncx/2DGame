using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;

    private float _sliderSmoothVelocity = 0.5f;

    private void Start()
    {
        _slider.maxValue = _health.Maximum;
        _slider.value = _health.Current;
    }

    public void StartChangeBar()
    {
        var ChangeBarJob = StartCoroutine(ChangeBarView());
    }

    private IEnumerator ChangeBarView()
    {
        while (_slider.value != _health.Current)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.Current, _health.Points / _sliderSmoothVelocity * Time.deltaTime);
            yield return null;
        }
    }
}