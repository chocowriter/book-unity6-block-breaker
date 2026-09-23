using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    [SerializeField] private float speed = 6f;
    [SerializeField] private Vector2 startDirection = new Vector2(1f, 1f);

    private Rigidbody2D rb;
    private Vector3 startPosition;

    public float Speed => speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    private void Start()
    {
        Launch();
    }

    public void Launch()
    {
        rb.linearVelocity = startDirection.normalized * speed;
    }

    public void ResetBall()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPosition;
    }
}