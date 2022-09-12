using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    private const string IsRunning = "Running";
    private const string IsJumping = "Jumping";


    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Run(bool isRunning)
    {
        _animator.SetBool(IsRunning, isRunning);
    }

    public void Jump(bool iJumping)
    {
        _animator.SetBool(IsJumping, iJumping);
    }
}
