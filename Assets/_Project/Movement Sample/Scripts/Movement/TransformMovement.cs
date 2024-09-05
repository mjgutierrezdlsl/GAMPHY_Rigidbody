using UnityEngine;

public class TransformMovement : MovementController
{
    protected override void Move(Vector2 direction, float deltaTime)
    {
        transform.Translate(direction * Speed * deltaTime);
    }

    protected virtual void Update()
    {
        Move(Vector2.right, Time.deltaTime);
    }
}