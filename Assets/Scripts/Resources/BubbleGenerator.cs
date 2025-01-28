using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Character")]
public class BubbleGenerator : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float spawnInterval = 0.5f;
    public Vector3 spawnPositionOffset = new Vector3(0, 1, 1);

    private float timeSinceLastSpawn = 0f;

    // public int characterCost;
    // public string characterName;
    // public Sprite characterArt;
    // public int characterMaxNumber;


    private void SpawnBubble()
    {
        Vector3 spawnPosition = transform.position + spawnPositionOffset;
        Instantiate(bubblePrefab, spawnPosition, Quaternion.identity);
    }


    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        while (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnBubble();
            timeSinceLastSpawn -= spawnInterval;
        }
    }
}
