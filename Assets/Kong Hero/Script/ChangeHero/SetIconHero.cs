using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetIconHero : MonoBehaviour
{
    public Image CurrentIcon;

    void Start()
    {
        switch (CharacterHolder.Instance.ChangeHero)
        {
            case ChangeHero.Monkey:
                SetMonkeyIcon();
                break;

            case ChangeHero.Hunter:
                SetHunterIcon();
                break;
        }
    }

    private void SetMonkeyIcon()
    {
        var iconMonkey = CharacterHolder.Instance.monkeyImage;
        CurrentIcon.sprite = iconMonkey;
    }

    private void SetHunterIcon()
    {
        var iconHunter = CharacterHolder.Instance.hunterImage;
        CurrentIcon.sprite = iconHunter;
    }
}
