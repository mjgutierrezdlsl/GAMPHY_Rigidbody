using UnityEngine;

public class Wall : MonoBehaviour
{
    private bool _isActive;
    public void OnTrigger(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _isActive = !_isActive;
            gameObject.SetActive(_isActive);
        }
    }
}