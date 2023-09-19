using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuHomeScene : MonoBehaviour
{
    public static MainMenuHomeScene Instance;

    public GameObject StartMenu;
    public GameObject WorldsChoose;
    public GameObject LoadingScreen;
    public GameObject LevelsChoose;
    public GameObject CharacterChoose;
    public GameObject ShopIcon;
    public GameObject SoundIcon;
    public GameObject HelpIcon;
    public GameObject Helper;
    public GameObject[] WorldLevel;

    [SerializeField] private Text world1;
    [SerializeField] private Text world2;
    [SerializeField] private Text world3;
    [SerializeField] private Text world4;

    SoundManager soundManager;

    void Awake()
    {
        Instance = this;
        soundManager = FindObjectOfType<SoundManager>();

        world1.text = Localisation.GetString("WorldTitleText1");
        world2.text = Localisation.GetString("WorldTitleText2");
        world3.text = Localisation.GetString("WorldTitleText3");
        world4.text = Localisation.GetString("WorldTitleText4");
    }

    
    void Start()
    {
        StartMenu.SetActive(true);
        WorldsChoose.SetActive(false);
        LevelsChoose.SetActive(false);
        CharacterChoose.SetActive(false);

    }

    public void OpenWorld(int world)
    {
        WorldsChoose.SetActive(false);
        LevelsChoose.SetActive(true);

        ReactionEscape.EscapeReaction.Instance.EscapeReactionStates = ReactionEscape.EscapeReactionStates.FromLevelChoose;

        for (int i = 0; i < WorldLevel.Length; i++)
        {
            if (i == (world - 1))
            {
                WorldLevel[i].SetActive(true);
            }
            else
                WorldLevel[i].SetActive(false);
        }

        SoundManager.PlaySfx(soundManager.soundClick);
    }

    public void OpenWorldChoose()
    {
        StartMenu.SetActive(false);
        WorldsChoose.SetActive(true);
        LevelsChoose.SetActive(false);
        ReactionEscape.EscapeReaction.Instance.EscapeReactionStates = ReactionEscape.EscapeReactionStates.FromWorldChoose;

        SoundManager.PlaySfx(soundManager.soundClick);
    }

    public void OpenStartMenu()
    {
        StartMenu.SetActive(true);
        WorldsChoose.SetActive(false);
        CharacterChoose.SetActive(false);
        ReactionEscape.EscapeReaction.Instance.EscapeReactionStates = ReactionEscape.EscapeReactionStates.FromMenu;

        SoundManager.PlaySfx(soundManager.soundClick);
    }

    public void OpenCharacterChoose()
    {
        StartMenu.SetActive(false);
        CharacterChoose.SetActive(true);
        ReactionEscape.EscapeReaction.Instance.EscapeReactionStates = ReactionEscape.EscapeReactionStates.FromShop;

        SoundManager.PlaySfx(soundManager.soundClick);
    }
    public void OpenHelpPanel()
    {
        Helper.SetActive(true);
        ReactionEscape.EscapeReaction.Instance.EscapeReactionStates = ReactionEscape.EscapeReactionStates.FromHelp;
        ShopIcon.SetActive(false);
        SoundIcon.SetActive(false);
        HelpIcon.SetActive(false);
    }

    public void CloseHelpPanel()
    {
        ShopIcon.SetActive(true);
        SoundIcon.SetActive(true);
        HelpIcon.SetActive(true);
        Helper.SetActive(false);
        ReactionEscape.EscapeReaction.Instance.EscapeReactionStates = ReactionEscape.EscapeReactionStates.FromMenu;
    }

}
