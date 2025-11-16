using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipePair;      // Prefab containing both top and bottom pipes with a gap
    public float spawnRate = 2f;
    private float timer = 0f;

    // Adjust these limits based on your camera’s visible area and the height of your pipePair prefab
    public float minY = -3f; // Bottom-most Y for pipe center
    public float maxY = 3f;  // Top-most Y for pipe center

    void Start()
    {
        SpawnPipePair();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipePair();
            timer = 0f;
        }
    }

    void SpawnPipePair()
    {
        // Get the height of the pipePair prefab using its BoxCollider2D (set to match the pair's height)
        float halfPipeHeight = pipePair.GetComponent<BoxCollider2D>().size.y / 2f;

        // Range is clamped so the whole pair stays on-screen
        float spawnY = Random.Range(minY + halfPipeHeight, maxY - halfPipeHeight);

        Instantiate(
            pipePair,
            new Vector3(transform.position.x, spawnY, 0),
            Quaternion.identity
        );
    }
}
