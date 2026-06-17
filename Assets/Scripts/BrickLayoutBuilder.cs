using UnityEngine;

namespace BlockBreaker
{
    public class BrickLayoutBuilder : MonoBehaviour
    {
        [SerializeField] private GameObject brickPrefab;
        [SerializeField] private int rows = 4;
        [SerializeField] private int columns = 8;
        [SerializeField] private Vector2 spacing = new Vector2(1.2f, 0.5f);
        [SerializeField] private Vector2 startPosition = new Vector2(-4.2f, 3f);

        private void Awake()
        {
            Build();
        }

        private void Build()
        {
            if (brickPrefab == null)
            {
                Debug.LogWarning("Brick Prefab이 연결되지 않았습니다.");
                return;
            }

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    Vector2 position = startPosition + new Vector2(x * spacing.x, -y * spacing.y);
                    Instantiate(brickPrefab, position, Quaternion.identity, transform);
                }
            }
        }
    }
}