using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneManager : MonoBehaviour
{

    [SerializeField] private GameObject Male;
    [SerializeField] private GameObject Female;
    [SerializeField] private GameObject Kid;
    [SerializeField] private CameraController cameraController;

    public GameObject playerPrefab;  // 생성된 플레이어 프리팹
    
    private Text nameTxt;
    private GameObject currentCharacter;
    private void Awake()
    {
        SpawnCharacter();  // 캐릭터를 Awake에서 생성
    }

    private void Start()
    {
        playerPrefab = GameObject.FindWithTag("Player");

        if (playerPrefab != null)
        {
            // 자식 요소 중 Text 컴포넌트를 찾음
            nameTxt = playerPrefab.GetComponentInChildren<Text>();

            if (nameTxt != null)
            {
                // 플레이어 이름을 설정
                nameTxt.text = GameManager.instance.OutputPlayerName();
            }
            else
            {
                Debug.LogError("Text UI를 찾을 수 없습니다.");
            }
        }
        else
        {
            Debug.LogError("Player Prefab을 찾을 수 없습니다.");
        }
    }

    private void SpawnCharacter()
    {
        CharacterClass selectedClass = GameManager.instance.GetSelectedCharacter();

        switch (selectedClass)
        {
            case CharacterClass.Male:
                currentCharacter = Instantiate(Male);
                break;
            case CharacterClass.Female:
                currentCharacter = Instantiate(Female);
                break;
            case CharacterClass.Kid:
                currentCharacter = Instantiate(Kid);
                break;
        }

        cameraController.SetTarget(currentCharacter.transform); // 태그 방식으로 나중에 변경 

    }
}

