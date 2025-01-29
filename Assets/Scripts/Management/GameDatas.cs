using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "GameDatas", menuName = "Scriptable Objects/GameDatas")]
public class GameDatas : ScriptableObject
{
    public Dictionary<string, float> bubbleCounts = new Dictionary<string, float>();
    
}
