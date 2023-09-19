using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuHelper : MonoBehaviour
{
    public GameObject Helper;

    [SerializeField] private Text titleText;
    [SerializeField] private Text leftText;
    [SerializeField] private Text rightText;
    [SerializeField] private Text jumpText;
    [SerializeField] private Text meleeAttackText;
    [SerializeField] private Text rangeAttackText;

    void Awake()
    {
        titleText.text = Localisation.GetString("ControllerPC");
        leftText.text = Localisation.GetString("MoveLeftHelp");
        rightText.text = Localisation.GetString("MoveRightHelp");
        jumpText.text = Localisation.GetString("JumpHelp");
        meleeAttackText.text = Localisation.GetString("MeleeAttackHelp");
        rangeAttackText.text = Localisation.GetString("RangeAttackHelp");
    }

    void Start()
    {
        HideHelper();
    }

    public void ShowHelper()
    {
        Helper.SetActive(true);
    }

    public void HideHelper()
    {
        Helper.SetActive(false);
    }
}
