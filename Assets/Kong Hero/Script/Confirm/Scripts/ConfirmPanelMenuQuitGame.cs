using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConfirmPanelMenuQuitGame : MonoBehaviour
{
    [SerializeField] private Text titleConfirm;
    [SerializeField] private Text yesText;
    [SerializeField] private Text noText;

    private void Start()
    {
        titleConfirm.text = Localisation.GetString("QuitMenu");
        yesText.text = Localisation.GetString("YesConfirm");
        noText.text = Localisation.GetString("NoConfirm");
    }
}
