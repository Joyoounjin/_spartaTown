//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;

//public class CharacterSelection : MonoBehaviour
//{
//    [SerializeField] private Button Male;
//    [SerializeField] private Button Female;
//    [SerializeField] private GameObject PlayerName;

//    public void Start()
//    {
//        Male.onClick.AddListener(() => SelectCharacter(CharacterClass.Male));
//        Female.onClick.AddListener(() => SelectCharacter(CharacterClass.Female));
//    }

//    public void SelectCharacter(CharacterClass characterClass)
//    {
//        GameManager.instance.SetSelectedCharacter(characterClass);
//        gameObject.SetActive(false);
//        PlayerName.SetActive(true);
//    }
//}

