using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }
    public void OnWalk(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;

        if (Mathf.Abs(moveInput.x) > Mathf.Abs(moveInput.y))
        {
            moveInput.y = 0; // 상하 방향을 0으로 설정
        }
        else
        {
            moveInput.x = 0; // 좌우 방향을 0으로 설정
        }

        CallWalkEvent(moveInput);
    }
}