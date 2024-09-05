using UnityEngine;

public abstract class RigidbodyMovement : MovementController
{
    [field: SerializeField] protected Rigidbody2D _rigidbody { get; set; }

    protected virtual void FixedUpdate()
    {
        Move(Vector2.right, Time.fixedDeltaTime);
    }
}