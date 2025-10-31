using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [Header("Fade Settings")]
    public float fadeInDuration = 0.5f;

    public float delay = 0.5f; 

    public LeanTweenType easeType = LeanTweenType.linear; 

    private CanvasGroup canvasGroup;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();

        if (canvasGroup == null)
        {
            return;
        }

       
        canvasGroup.alpha = 0f;

        
        LeanTween.alphaCanvas(canvasGroup, 1f, fadeInDuration)
            .setEase(easeType)
            .setDelay(delay);
    }
}