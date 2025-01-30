using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using TMPro.Examples;


public class ButtonManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameDatas gameDatas; //

    public List<Character> Characters = new List<Character>();


    public GameObject popUp;
    public GameObject CharactersMenu;
    public bool CharactersMenuIsOpen;

    public List<TextMeshProUGUI> textBubbleTypes = new List<TextMeshProUGUI>();

    public List<string> bubbleTypes = new List<string>();


    void Awake()
    {

        //
        for (int i = 0; i < Characters.Count; i++)
        {
            Characters[i].alreadyPop = false;
        }

        UpdateCharactersMenu();
    }

    // Update is called once per frame
    void Update()
    {
        ActivatePopUp();
        UpdateGameRessourcesUI();
    }

    public void ActivatePopUp()
    {
        for (int i = 0; i < Characters.Count; i++)
        {

            if (gameDatas.bubbleCounts[Characters[i].CharacterCostType] >= Characters[i].characterCost && !Characters[i].alreadyPop && Characters[i].characterNumberAlreadyOwned < Characters[i].maxCharacterNumber)
            {
                Characters[i].alreadyPop = true;
                GameObject popUpGameObject = Instantiate(popUp, this.transform, false);
                ButtonClicked popUpScript = popUpGameObject.GetComponent<ButtonClicked>(); //
                popUpScript.character = Characters[i]; //
                TextMeshProUGUI PopUpText = popUpGameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                Image PopUpImage = popUpGameObject.transform.GetChild(1).GetComponent<Image>();
                PopUpImage.sprite = Characters[i].characterImage;
                PopUpText.text = Characters[i].characterCost.ToString();
            }
        }
    }

    public void UpdateGameRessourcesUI()
    {
        for (int i = 0; i < textBubbleTypes.Count; i++)
        {
            textBubbleTypes[i].text = gameDatas.bubbleCounts[bubbleTypes[i]].ToString();
        }
        return;
    }

    public void UpdateCharactersMenu()
    {
        int index = 0;
        for (int i = 0; i < 2; i++)
        {
            Transform horizontalMenu = CharactersMenu.transform.GetChild(i);
            for (int y = 0; y < horizontalMenu.transform.childCount; y++)
            {
                Transform characterSheet = horizontalMenu.transform.GetChild(y);

                TextMeshProUGUI characterName = characterSheet.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                Image characterImage = characterSheet.transform.GetChild(1).GetComponent<Image>();
                TextMeshProUGUI characterCost = characterSheet.transform.GetChild(2).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                Image characterCostImage = characterSheet.transform.GetChild(2).transform.GetChild(1).GetComponent<Image>();
                TextMeshProUGUI characterProduction = characterSheet.transform.GetChild(3).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                Image characterProductionImage = characterSheet.transform.GetChild(3).transform.GetChild(1).GetComponent<Image>();

                characterName.text = Characters[index].characterName;
                characterImage.sprite = Characters[index].characterImage;
                characterCost.text = Characters[index].characterCost.ToString();
                characterCostImage.sprite = Characters[index].CharacterCostTypeImage;
                characterProduction.text = Characters[index].bubblesPerMinute.ToString();
                characterProductionImage.sprite = Characters[index].bubbleTypeImage;

                index++;
            }
        }
    }

    //
    public void ActivateCharactersMenu()
    {
        if (CharactersMenuIsOpen)
        {
            CharactersMenu.SetActive(false);
        }
        else
        {
            CharactersMenu.SetActive(true);
        }

        CharactersMenuIsOpen = !CharactersMenuIsOpen;
    }
}
