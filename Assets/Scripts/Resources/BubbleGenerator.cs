using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Character")]
public class BubbleGenerator : MonoBehaviour
{
    [SerializeField] Character characterScriptable;
    public Transform spawnPosition;

    private float timeSinceLastSpawn = 0f;

    private void SpawnBubble()
    {
        Vector3 spawnPositionVector = spawnPosition.position;
        Instantiate(characterScriptable.bubbleType, spawnPositionVector, Quaternion.identity);
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

    private void OnMouseDown()
    {
        SpawnBubble();
    }
}
