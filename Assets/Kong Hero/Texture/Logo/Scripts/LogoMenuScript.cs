using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoMenuScript : MonoBehaviour
{
    [SerializeField] private Sprite imageEngLogo;
    [SerializeField] private Sprite imageRuLogo;

    private void Start()
    {
        var currentLogo = gameObject.GetComponent<Image>();
        switch (Localisation.GetCurrentLanguage())
        {
            case Languages.Russian:
            case Languages.Belarusian:
            case Languages.Ukrainian:
                currentLogo.sprite = imageRuLogo;
                break;

            default:
                currentLogo.sprite = imageEngLogo;
                break;
        }
    }
}
