using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInputLogin : MonoBehaviour
{
    [SerializeField] private InputField playerinputName;
    [SerializeField] private GameObject invalidInputText;

    public void PlayerInputNameSave()
    {
        string playerName = playerinputName.text;

        // Player Name 2 ~ 5 글자 사이 제한
        if (string.IsNullOrEmpty(playerName) || playerName.Length < 2 || playerName.Length > 5)
        {
            invalidInputText.SetActive(true);  

            // 초기화 
            playerinputName.text = ""; 
            playerName = null;
            return;
        }

        // 게임 매니저에 이름 저장
        GameManager.instance.SettingPlayerName(playerName);
        // 씬 이동
        SceneManager.LoadScene("MainScene");
    }
}

