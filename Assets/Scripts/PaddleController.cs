using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private float minX = -7.5f;
    [SerializeField] private float maxX = 7.5f;

    private Vector3 startPosition;
    private SpriteRenderer spriteRenderer;

    public float Width
    {
        get
        {
            if (spriteRenderer == null)
            {
                return 1f;
            }

            return spriteRenderer.bounds.size.x;
        }
    }

    private void Awake()
    {
        startPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        Vector3 movement = Vector3.right * input * moveSpeed * Time.deltaTime;
        transform.position += movement;

        ClampPosition();
    }

    private void ClampPosition()
    {
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        transform.position = position;
    }

    public void ResetPaddle()
    {
        transform.position = startPosition;
    }
}