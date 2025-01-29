using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;


public class ButtonManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameManager gameManager;

    [SerializeField] Character character1;
    [SerializeField] Character character2;
    [SerializeField] Character character3;
    [SerializeField] Character character4;
    [SerializeField] Character character5;
    [SerializeField] Character character6;
    [SerializeField] Character character7;
    [SerializeField] Character character8;
    [SerializeField] Character character9;

    public List<Character> Characters = new List<Character>();


    public GameObject popUp;


    void Start()
    {
        Characters.Add(character1);
        Characters.Add(character2);
        Characters.Add(character3);
        Characters.Add(character4);
        Characters.Add(character5);
        Characters.Add(character6);
        Characters.Add(character7);
        Characters.Add(character8);
        Characters.Add(character9);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Characters.Count; i++)
        {
            if (gameManager.bubbleCounts[Characters[i].CharacterCostType] >= Characters[i].characterCost && !Characters[i].alreadyPop)
            {
                Characters[i].alreadyPop = true;
                GameObject popUpGameObject = Instantiate(popUp, this.transform, false);
                TextMeshPro PopUpText = popUpGameObject.transform.GetChild(0).GetComponent<TextMeshPro>();
                Image PopUpImage = popUpGameObject.transform.GetChild(1).GetComponent<Image>();
                PopUpImage.sprite = Characters[i].characterImage;
                PopUpText.text = Characters[i].characterCost.ToString();
            }
        }
    }

    public void PopUp(Character character)
    {
        Instantiate(character.Prefab);
        Destroy(this.gameObject);
    }
}
