using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSender : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) { return; }
        if (other.TryGetComponent<TriggerResponder>(out var responder))
        {
            responder.IsOnTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) { return; }
        if (other.TryGetComponent<TriggerResponder>(out var responder))
        {
            responder.IsOnTrigger = false;
        }
    }
}
