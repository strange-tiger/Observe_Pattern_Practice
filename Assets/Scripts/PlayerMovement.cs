using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotationSpeed = 120f;
    private PlayerInput _input;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        moveForward(_input.Y);
        rotateClockwise(_input.X);
    }

    private void moveForward(float direction)
    {
        // 1. Rigidbody�� �ӷ��� �̿��ϴ� ��� => �ִϸ��̼ǿ� ����
        // 2. �����̵��� ��Ű�� ���
        Vector3 deltaPosition = MoveSpeed * direction * Time.fixedDeltaTime * transform.forward;
        Vector3 newPosition = transform.position + deltaPosition;
        _rigidbody.MovePosition(newPosition);
    }

    private void rotateClockwise(float direction)
    {
        Quaternion deltaRotation = Quaternion.Euler(0f, RotationSpeed * direction * Time.fixedDeltaTime, 0f);
        Quaternion newRotation = transform.rotation * deltaRotation;
        _rigidbody.MoveRotation(newRotation);
    }
}
