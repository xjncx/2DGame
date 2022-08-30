using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Run(bool isRunning)
    {
        _animator.SetBool("Running", isRunning);
    }

    public void Jump(bool iJumping)
    {
        _animator.SetBool("Jumping", iJumping);
    }
}
