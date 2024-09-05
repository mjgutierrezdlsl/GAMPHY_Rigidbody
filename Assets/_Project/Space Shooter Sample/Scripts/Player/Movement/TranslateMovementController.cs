using UnityEngine;

public class TranslateMovementController : MovementController
{
    protected override Vector2 HandleInputDirection() => new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    protected override void Move(Vector2 direction, float deltaTime)
    {
        transform.position += deltaTime * Speed * (Vector3)direction;
    }
    protected override void Update()
    {
        base.Update();
        Move(Direction, Time.deltaTime);
    }
}