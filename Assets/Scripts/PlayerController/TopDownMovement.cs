using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;
    private Animator animator;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        movementController.OnWalkEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
        UpdateAnimation();
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }

    private void UpdateAnimation()
    {
        // 이동 중인지 애니메이터에 전달
        animator.SetBool("IsMoving", movementDirection != Vector2.zero);

        // 이동 방향 설정
        if (movementDirection.x != 0 || movementDirection.y != 0)
        {
            float angle = Mathf.Atan2(movementDirection.y, movementDirection.x) * Mathf.Rad2Deg;
            animator.SetFloat("MovementDirection", angle); // 이동 방향을 애니메이터에 설정
        }
    }
}
