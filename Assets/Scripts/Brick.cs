using UnityEngine;

namespace BlockBreaker
{
    public class Brick : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.GetComponent<BallController>() == null)
            {
                return;
            }

            Destroy(gameObject);
        }
    }
}