using UnityEngine;

public class DispawnBubble : MonoBehaviour
{
    public Sprite[] popFrames;
    private SpriteRenderer spriteRenderer;

    private int currentFrame = 0;

    public float frameRate = 0.1f;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    public void PlayPopAnimation()
    {
        StartCoroutine(AnimatePop());
    }


}
