using UnityEngine;

public class ForceMovementController : MovementController
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _maxSpeed;

    protected override Vector2 HandleInputDirection()
    {
        return new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    protected override void Move(Vector2 direction, float deltaTime)
    {
        _rigidbody.AddForce(deltaTime * Speed * direction);

        if (_rigidbody.velocity.magnitude > _maxSpeed)
        {
            _rigidbody.velocity = _rigidbody.velocity.normalized * _maxSpeed;
        }

    }
    private void FixedUpdate()
    {
        Move(Direction, Time.fixedDeltaTime);
    }
}