using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmPanelRestart : MonoBehaviour
{
    [SerializeField] private Text titleConfirm;
    [SerializeField] private Text yesText;
    [SerializeField] private Text noText;

    private void Start()
    {
        titleConfirm.text = Localisation.GetString("RestartGame");
        yesText.text = Localisation.GetString("YesConfirm");
        noText.text = Localisation.GetString("NoConfirm");
    }
}
