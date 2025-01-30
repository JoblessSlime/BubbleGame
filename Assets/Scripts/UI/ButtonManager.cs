using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using TMPro.Examples;


public class ButtonManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameDatas gameDatas; //

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
    public GameObject CharactersMenu;
    public bool CharactersMenuIsOpen;


    public TextMeshProUGUI textBubbleType1;
    public TextMeshProUGUI textBubbleType2;
    public TextMeshProUGUI textBubbleType3;
    public TextMeshProUGUI textBubbleType4;
    public TextMeshProUGUI textBubbleType5;
    public TextMeshProUGUI textBubbleType6;
    public TextMeshProUGUI textBubbleType7;
    public TextMeshProUGUI textBubbleType8;
    public TextMeshProUGUI textBubbleType9;

    private List<TextMeshProUGUI> textBubbleTypes = new List<TextMeshProUGUI>();


    void Awake()
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

        textBubbleTypes.Add(textBubbleType1);
        textBubbleTypes.Add(textBubbleType2);
        textBubbleTypes.Add(textBubbleType3);
        textBubbleTypes.Add(textBubbleType4);
        textBubbleTypes.Add(textBubbleType5);
        textBubbleTypes.Add(textBubbleType6);
        textBubbleTypes.Add(textBubbleType7);
        textBubbleTypes.Add(textBubbleType8);
        textBubbleTypes.Add(textBubbleType9);

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
            textBubbleTypes[i].text = gameDatas.bubbleCounts[Characters[i].CharacterCostType].ToString();
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
