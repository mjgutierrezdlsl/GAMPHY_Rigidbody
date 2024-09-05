using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovementController : MonoBehaviour
{
    [field: SerializeField] protected float Speed { get; set; }
    protected abstract void Move(Vector2 direction, float deltaTime);
}
