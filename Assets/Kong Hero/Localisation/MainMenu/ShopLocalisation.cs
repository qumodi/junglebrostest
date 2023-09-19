using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopLocalisation : MonoBehaviour
{
    [SerializeField] private Text titleShopText;
    [SerializeField] private Text liveShopText;
    [SerializeField] private Text bulletShopText;
    [SerializeField] private Text characterName1Text;
    [SerializeField] private Text characterName2Text;

    private GameObject mainMenuCharacterChooseScript;


    void Awake()
    {
        mainMenuCharacterChooseScript = GameObject.Find("Char 2");

        titleShopText.text = Localisation.GetString("CharacterSelection");
        liveShopText.text = Localisation.GetString("LivesShop");
        bulletShopText.text = Localisation.GetString("BuletsShop");
        characterName1Text.text = Localisation.GetString("CharacterName1");
        characterName2Text.text = Localisation.GetString("CharacterName2");
    }

    public void SwitchHeroMonkey()
    {
        CharacterHolder.Instance.ChangeHero = ChangeHero.Monkey;
        CharacterHolder.Instance.SwitchCharacter();
    }

    public void SwitchHeroHunter()
    {
        if (mainMenuCharacterChooseScript.GetComponent<MainMenu_ChracterChoose>().isUnlock)
        {
            CharacterHolder.Instance.ChangeHero = ChangeHero.Hunter;
            CharacterHolder.Instance.SwitchCharacter();
        }
    }
}
