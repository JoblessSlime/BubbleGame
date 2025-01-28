using UnityEngine;

public class SpawnBubble : MonoBehaviour
{
    [SerializeField] Character character;
    public float time = 0;

    void Update()
    {
        time += Time.deltaTime;
        if (time >= character.timeToSpawn)
        {
            time = 0;
            for (int i = 0; i < character.bubbleNumber; i++)
            {
                GameObject.Instantiate(character.bubbleType);
            }
        }
    }
}
