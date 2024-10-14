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

        // Player Name 2 ~ 5 ���� ���� ����
        if (string.IsNullOrEmpty(playerName) || playerName.Length < 2 || playerName.Length > 5)
        {
            invalidInputText.SetActive(true);  

            // �ʱ�ȭ 
            playerinputName.text = ""; 
            playerName = null;
            return;
        }

        // ���� �Ŵ����� �̸� ����
        GameManager.instance.SettingPlayerName(playerName);
        // �� �̵�
        SceneManager.LoadScene("MainScene");
    }
}

