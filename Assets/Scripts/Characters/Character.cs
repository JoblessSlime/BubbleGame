using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Character")]
public class Character : ScriptableObject
{
    public float timeToSpawn;

    public float bubblesPerMinute;

    public int bubbleNumber;

    public GameObject bubbleType;

    public List<Transform> characterPosition;

    public int characterCost;

    public string CharacterCostType;

    public Sprite characterImage;

    public Sprite CharacterCostTypeImage;

    public Sprite bubbleTypeImage;

    public int maxCharacterNumber;

    public int characterNumberAlreadyOwned;

    public string characterName;

    public bool alreadyPop;

    public GameObject Prefab;
}
