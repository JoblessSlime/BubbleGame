using UnityEngine;

public class ButtonClicked : MonoBehaviour
{
    public Character character;
    public GameDatas gameDatas;

    //
    public void PopUp()
    {
        Instantiate(character.Prefab, character.characterPlacement[character.characterNumberAlreadyOwned], Quaternion.identity);
        Destroy(this.gameObject);
        //
        character.alreadyPop = false;
        character.characterNumberAlreadyOwned += 1;
        gameDatas.bubbleCounts[character.CharacterCostType] -= character.characterCost;
    }


}
