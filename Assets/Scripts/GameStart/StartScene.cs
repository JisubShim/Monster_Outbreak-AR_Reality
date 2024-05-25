using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // ���� ����
    public void StartButton()
    {
        SceneManager.LoadScene("InGame");
    }

    // ���� ����
    public void GameExit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                        Application.Quit(); // ���ø����̼� ����
        #endif
    }
}