using UnityEngine;

public class VelocityMovement : RigidbodyMovement
{
    protected override void Move(Vector2 direction, float deltaTime)
    {
        // deltaTime is not used because we are already setting
        // how much our object's speed
        _rigidbody.velocity = direction * Speed;
    }
}