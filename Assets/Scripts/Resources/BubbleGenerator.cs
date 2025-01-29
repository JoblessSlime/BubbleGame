using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Character")]
public class BubbleGenerator : MonoBehaviour
{
    [SerializeField] Character characterScriptable;
    public Vector3 spawnPositionOffset = new Vector3(0, 1, 1);

    private float timeSinceLastSpawn = 0f;

    private void SpawnBubble()
    {
        Vector3 spawnPosition = transform.position + spawnPositionOffset;
        Instantiate(characterScriptable.bubbleType, spawnPosition, Quaternion.identity);
    }


    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= characterScriptable.timeToSpawn)
        {
            for (int i = 0; i < characterScriptable.bubbleNumber; i++)
            {
                SpawnBubble();
                timeSinceLastSpawn = 0;
            }
        }
    }
}
