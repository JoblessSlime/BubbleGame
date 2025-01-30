using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public AudioSource audioSource;

    [SerializeField] GameDatas gameDatas;

    private void Awake()
    {
        gameDatas.bubbleCounts.Clear(); //

        Instance = this;
        gameDatas.bubbleCounts["A"] = 0;
        gameDatas.bubbleCounts["B"] = 0;
        gameDatas.bubbleCounts["C"] = 0;
        gameDatas.bubbleCounts["D"] = 0;
        gameDatas.bubbleCounts["E"] = 0;
        gameDatas.bubbleCounts["F"] = 0;
        gameDatas.bubbleCounts["G"] = 0;
        gameDatas.bubbleCounts["H"] = 0;
        gameDatas.bubbleCounts["I"] = 0;
    }
    public void AddBubble(string type, float amount)
    {
        audioSource.Play();
        if (!gameDatas.bubbleCounts.ContainsKey(type))
            gameDatas.bubbleCounts[type] = 0;

        gameDatas.bubbleCounts[type] += amount;
        Debug.Log(gameDatas.bubbleCounts[type]);
    }

    void Update()
    {
        // afficher les valeurs
    }
}