using UnityEngine;

public class Animation : MonoBehaviour
{
    [Header("Animation Settings")]
    public float slideDuration = 0.5f;
    public LeanTweenType easeType = LeanTweenType.easeOutQuad;
    public float delay = 0f; 

    [Header("Start Offset (From Final Position)")]
    public float startOffsetX = 0f; 
    public float startOffsetY = 0f; 

    private RectTransform rect;
    private Vector2 targetPosition;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        
       
        targetPosition = rect.anchoredPosition;

        
        Vector2 startPosition = new Vector2(
            targetPosition.x + startOffsetX,
            targetPosition.y + startOffsetY
        );
        rect.anchoredPosition = startPosition;

        
        LeanTween.move(rect, targetPosition, slideDuration)
            .setEase(easeType)
            .setDelay(delay);
    }
}