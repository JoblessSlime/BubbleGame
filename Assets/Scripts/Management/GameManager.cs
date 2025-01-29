using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public TMPro.TextMeshProUGUI bubbleCountText;

    private float bubbleCount = 0;
    public Dictionary<string, float> bubbleCounts = new Dictionary<string, float>();


    private void Awake()
    {
        Instance = this;
        bubbleCounts["A"] = 0;
        bubbleCounts["B"] = 0;
        bubbleCounts["C"] = 0;
        bubbleCounts["D"] = 0;
        bubbleCounts["E"] = 0;
        bubbleCounts["F"] = 0;
        bubbleCounts["G"] = 0;
        bubbleCounts["H"] = 0;
        bubbleCounts["I"] = 0;
    }

    public void AddBubble(string type, float amount)
    {
        if (!bubbleCounts.ContainsKey(type))
            bubbleCounts[type] = 0;

        bubbleCounts[type] += amount;
        Debug.Log(bubbleCounts[type]);
    }

    void Update()
    {

    }
}