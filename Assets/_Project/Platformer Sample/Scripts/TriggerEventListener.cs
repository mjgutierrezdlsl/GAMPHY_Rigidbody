using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventListener : MonoBehaviour
{
    [SerializeField] UnityEvent<Collider2D> _onEnter, _onStay, _onExit;
    private void OnTriggerEnter2D(Collider2D other)
    {
        _onEnter?.Invoke(other);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        _onStay?.Invoke(other);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        _onExit?.Invoke(other);
    }
}
