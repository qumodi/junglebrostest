using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldChooseLocalisation : MonoBehaviour
{
    [SerializeField] private Text titileWorldChooseText;

    void Start()
    {
        titileWorldChooseText.text = Localisation.GetString("TitleWorld");
    }
}
