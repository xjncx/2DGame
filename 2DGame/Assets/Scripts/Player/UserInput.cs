using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]


//3. _animator.SetBool("Running", isRunning); Рекомендуется использовать хеши или константы при обращении к аниматору. Сделать это можно, рассчитав хеш через Animator.StringToHash. Затем передаем хеш вместо строкового литерала. По этому поводу есть рекомендация: https://agava.notion.site/40e2798c8c32487583180b03cbc5fccd но там пока что не добавлен пункт о хешах.


public class UserInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        bool isJumpButtonPressed = Input.GetButtonDown("Jump");

        _playerMovement.Move(horizontalDirection, isJumpButtonPressed);
    }
}
