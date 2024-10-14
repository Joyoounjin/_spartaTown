using UnityEngine;
using UnityEngine.UI;

public class StartSceneManager : MonoBehaviour
{
    [SerializeField] private GameObject GameStartScene;
    [SerializeField] private GameObject CharaterSelectUI;
    [SerializeField] private GameObject PlayerNameUI;

    // 선택 시 스프라이트 변경 
    //public SpriteRenderer FemaleSpriteRenderer;
    //public SpriteRenderer MaleSpriteRenderer;
    //public SpriteRenderer KidSpriteRenderer;

    public void OnclickGameStartBtn()
    {
        GameStartScene.SetActive(false);
        CharaterSelectUI.SetActive(true);
    }

    public void SelectCharacter(int characterIndex)
    {
        //Sprite MaleselectSPrite = Resources.Load<Sprite>("Sprites/LudoSmile");

        CharacterClass selectedClass;

        switch (characterIndex)
        {
            case 0: // female
                selectedClass = CharacterClass.Female;
                Debug.Log("Character 1 Selected");
                break;
            case 1: // male
                selectedClass = CharacterClass.Male;
                Debug.Log("Character 2 Selected");
                break;
            case 2: // kid
                selectedClass = CharacterClass.Kid;
                Debug.Log("Character 3 Selected");
                break;
            default:
                Debug.LogError("Invalid character index");
                return;
        }

        GameManager.instance.SetSelectedCharacter(selectedClass);

        CharaterSelectUI.SetActive(false);
        PlayerNameUI.SetActive(true);
    }
}

