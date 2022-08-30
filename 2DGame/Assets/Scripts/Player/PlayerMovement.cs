using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement vars")]
    [SerializeField] private float _speed;
    [SerializeField] private float jumpForce;

    private Transform _playerTransform;
    private PlayerAnimation _playerAnimation;
    private Rigidbody2D _rb2d;
    private bool _isMovingForward;

    private void Awake()
    {
        _playerTransform = GetComponent<Transform>();
        _playerAnimation = GetComponentInChildren<PlayerAnimation>();
        _rb2d = GetComponent<Rigidbody2D>();
        _isMovingForward = true;
    }

    private void FixedUpdate()
    {
        if (_rb2d.velocity.y <= 0.1)
        {
            _playerAnimation.Jump(false);
        }
    }

    public void Move(float direction, bool isJumpButtonPressed)
    {
        if (isJumpButtonPressed)
        {
            Jump();
        }

        if (Mathf.Abs(direction) > 0.01f)
        {
            _playerAnimation.Run(true);
            HorizontalMovement(direction);
            if (direction > 0)
            {
                _isMovingForward = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }

            if (direction < 0)
            {
                _isMovingForward = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
        else
        {
            _playerAnimation.Run(false);
        }
    }

    private void HorizontalMovement(float direction)
    {
        _rb2d.velocity = new Vector2(direction * _speed, _rb2d.velocity.y);
    }

    private void Jump()
    {
        _playerAnimation.Jump(true);
        _rb2d.velocity = new Vector2(_rb2d.velocity.x, jumpForce);
    }
}

