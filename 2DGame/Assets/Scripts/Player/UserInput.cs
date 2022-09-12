using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]


//3. _animator.SetBool("Running", isRunning); ������������� ������������ ���� ��� ��������� ��� ��������� � ���������. ������� ��� �����, ��������� ��� ����� Animator.StringToHash. ����� �������� ��� ������ ���������� ��������. �� ����� ������ ���� ������������: https://agava.notion.site/40e2798c8c32487583180b03cbc5fccd �� ��� ���� ��� �� �������� ����� � �����.


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
