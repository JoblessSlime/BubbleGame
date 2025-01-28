using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Character")]
public class Character : ScriptableObject
{
    public float timeToSpawn;
    public int bubbleNumber;

    public GameObject bubbleType;

    public int characterCost;

    public string characterName;

    public Sprite characterArt;

    public int characterMaxNumber;
}
