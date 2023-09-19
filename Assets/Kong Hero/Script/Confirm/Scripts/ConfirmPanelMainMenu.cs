using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ConfirmPanelMainMenu : MonoBehaviour
{
    [SerializeField] private Text titleConfirm;
    [SerializeField] private Text yesText;
    [SerializeField] private Text noText;

    private void Start()
    {
        titleConfirm.text = Localisation.GetString("QuitGame");
        yesText.text = Localisation.GetString("YesConfirm");
        noText.text = Localisation.GetString("NoConfirm");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}


