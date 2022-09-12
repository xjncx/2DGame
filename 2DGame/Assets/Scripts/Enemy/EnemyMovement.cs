using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

//if (_enemySprite.flipX == false) { _enemySprite.flipX = true; }
//else { _enemySprite.flipX = false; }
// _enemySprite.flipX = target.transform.position.x < _enemySprite.transform.position.x
//Во первых тут нужна проверка нужен ли разворот вообще или нет, точка может быть правее предыдущей и разворот не понадобиться, во вторых всё это можно сократить _enemySprite.flipX = ! _enemySprite.flipX;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _path;

    private Transform[] _points;
    private int _currentPoint;
    private SpriteRenderer _enemySprite;
    private Rigidbody2D _rb2d;

    private void Start()
    {
        _enemySprite = GetComponent<SpriteRenderer>();
        _points = new Transform[_path.childCount];
        _rb2d = GetComponentInParent<Rigidbody2D>();

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void FixedUpdate()
    {
        Transform target = _points[_currentPoint];
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        _enemySprite.flipX = target.transform.position.x < _enemySprite.transform.position.x;

        if (transform.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
