using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Character")]
public class Character : ScriptableObject
{
    public float timeToSpawn;

    public int bubbleNumber;

    public GameObject bubbleType;

    public int characterCost;

    public string CharacterCostType;

    public Sprite characterImage;

    public int maxCharacterNumber;

    public string characterName;

    public bool alreadyPop;

    public GameObject Prefab;
}
