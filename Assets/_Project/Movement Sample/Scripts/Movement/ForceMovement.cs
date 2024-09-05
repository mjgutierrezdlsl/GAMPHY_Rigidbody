using UnityEngine;

public class ForceMovement : RigidbodyMovement
{
    protected override void Move(Vector2 direction, float deltaTime)
    {
        _rigidbody.AddForce(direction * Speed * deltaTime);
    }
}