using UnityEngine;

public class TriggerResponder : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Color baseColor, triggeredColor;

    private bool _isOnTrigger;
    public bool IsOnTrigger
    {
        get => _isOnTrigger;
        set
        {
            _isOnTrigger = value;
            SetActiveColor();
        }
    }

    private void SetActiveColor()
    {
        spriteRenderer.color = _isOnTrigger ? triggeredColor : baseColor;
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}