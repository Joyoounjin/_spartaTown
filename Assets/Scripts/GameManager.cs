using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Instance
    public static GameManager instance = null;

    private void Awake()
    {
        // instance가 null이라면
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        // 이미 존재한다면
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion

    // 플레이어 이름
    private string playerName;
    private CharacterClass selectedCharacterClass;

    // 플레이어 이름 저장
    public void SettingPlayerName(string name)
    {
        playerName = name;
    }

    // 플레이어 이름 불러오기
    public string OutputPlayerName()
    {
        return playerName;
    }

    public void SetSelectedCharacter(CharacterClass characterClass)
    {
        selectedCharacterClass = characterClass;
    }

    public CharacterClass GetSelectedCharacter()
    {
        return selectedCharacterClass;
    }
}
