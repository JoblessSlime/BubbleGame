using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public TMPro.TextMeshProUGUI bubbleCountText;

    private float bubbleCount = 0;
    private Dictionary<string, float> bubbleCounts = new Dictionary<string, float>();


    private void Awake()
    {
        Instance = this;
    }

    public void AddBubble(string type, float amount)
    {
        if (!bubbleCounts.ContainsKey(type))
            bubbleCounts[type] = 0;

        bubbleCounts[type] += amount;
    }

    void Update()
    {
        string displayText = "Bulles collectées :\n";

        float total = 0;

        foreach (var kvp in bubbleCounts)
        {
            total += kvp.Value;
            displayText += $"{kvp.Key} : {kvp.Value}\n";
        }

        displayText += $"\nTotal : {total}";

        bubbleCountText.text = displayText;
    }

    public float GetBubbleCount()
    {
        return bubbleCount;
    }
}