using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMovement : RigidbodyMovement
{
    protected override void Move(Vector2 direction, float deltaTime)
    {
        _rigidbody.MovePosition(_rigidbody.position + direction * Speed * deltaTime);
    }
}
