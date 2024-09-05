using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _disableDuration = 1f;
    [SerializeField] Collider2D _collider;
    public void DisablePlatform()
    {
        StartCoroutine(ColliderDisableRoutine());
    }
    private IEnumerator ColliderDisableRoutine()
    {
        _collider.enabled = false;
        yield return new WaitForSeconds(_disableDuration);
        _collider.enabled = true;
    }
}
