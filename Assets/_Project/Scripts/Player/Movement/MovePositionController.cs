using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionController : MovementController
{
    [SerializeField] private Rigidbody2D _rigidbody;
    protected override Vector2 HandleInputDirection()
    {
        return new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    protected override void Move(Vector2 direction, float deltaTime)
    {
        _rigidbody.MovePosition(_rigidbody.position + deltaTime * Speed * direction);
    }

    private void FixedUpdate()
    {
        Move(Direction, Time.fixedDeltaTime);
    }
}
