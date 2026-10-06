using UnityEngine;

namespace BlockBreaker
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private float lifeTime = 3f;
    
        private Vector2 moveDirection = Vector2.up;
        private float lifeTimer;
    
        private void OnEnable()
        {
            lifeTimer = 0f;
        }
    
        private void Update()
        {
            Move();
            CheckLifeTime();
        }
    
        public void SetDirection(Vector2 direction)
        {
            moveDirection = direction.normalized;
        }
    
        private void Move()
        {
            transform.position += (Vector3)(moveDirection * moveSpeed * Time.deltaTime);
        }
    
        private void CheckLifeTime()
        {
            lifeTimer += Time.deltaTime;
    
            if (lifeTimer >= lifeTime)
            {
                Destroy(gameObject);
            }
        }
    }
}
