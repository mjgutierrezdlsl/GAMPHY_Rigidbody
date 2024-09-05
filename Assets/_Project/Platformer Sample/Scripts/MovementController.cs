using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpForce = 20f;
    [SerializeField] private Rigidbody2D _rigidbody;
    private bool _isDownIntended;
    private bool _isGrounded;
    private Platform _currentPlatform;
    private void Update()
    {
        _rigidbody.velocity = new(Input.GetAxisRaw("Horizontal") * _moveSpeed, _rigidbody.velocity.y);

        _isDownIntended = Input.GetAxisRaw("Vertical") < 0f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!_isGrounded) { return; }

            if (_isDownIntended)
            {
                if (_currentPlatform == null)
                {
                    return;
                }
                _currentPlatform.DisablePlatform();
            }
            else
            {
                _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
        // Check if we just entered a platform
        if (!other.collider.TryGetComponent<Platform>(out var platform))
        {
            return;
        }
        // Store a reference to the current platform
        _currentPlatform = platform;

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (!other.collider.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
        // Check if we just left a platform
        if (!other.collider.TryGetComponent<Platform>(out var platform))
        {
            return;
        }
        // Remove platform reference
        _currentPlatform = null;

    }
}
