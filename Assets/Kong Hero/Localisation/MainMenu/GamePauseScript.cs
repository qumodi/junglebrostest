using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePauseScript : MonoBehaviour
{
    private Text gamePauseText;
    private GameObject quitMenuPanel;
    private GameObject restartPanel;

    void Start()
    {
        gamePauseText = GameObject.Find("GamePauseText").GetComponent<Text>();
        gamePauseText.text = Localisation.GetString("GamePause");

        quitMenuPanel = GameObject.Find("ConfirmPanelQuitMenuGame");
        restartPanel = GameObject.Find("ConfirmPanelRestartMenuGame");

    }

    public void OpenRestartPanel()
    {
        restartPanel.SetActive(true);
    }

    public void OpenQuitMenuPanel()
    {
        quitMenuPanel.SetActive(true);
    }
}
