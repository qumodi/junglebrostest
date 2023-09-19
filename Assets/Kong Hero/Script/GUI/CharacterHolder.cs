using UnityEngine;
using System.Collections;

public enum ChangeHero
{
    Monkey,
    Hunter
}


public class CharacterHolder : MonoBehaviour
{

    public static CharacterHolder Instance;
    //[HideInInspector]
    public GameObject CharacterPicked;

    public GameObject[] Characters;

    public ChangeHero ChangeHero { get { return changeHero; } set { changeHero = value; } }
    private ChangeHero changeHero;

    public Sprite monkeyImage;
    public Sprite hunterImage;



    void Awake()
    {
        if (CharacterHolder.Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        GetPickedCharacter();
    }

    void Start()
    {
        PlayerPrefs.GetInt("setMonkey");

        if (PlayerPrefs.GetInt("setMonkey") == 0)
        {
            changeHero = ChangeHero.Monkey;
        }
        else
        {
            changeHero = ChangeHero.Hunter;
        }
    }




    public void SwitchCharacter()
    {
        switch (changeHero)
        {
            case ChangeHero.Monkey:
                Debug.Log("u are choose Hero - Monkey");
                PlayerPrefs.SetInt("setMonkey", 0);
                break;

            case ChangeHero.Hunter:
                Debug.Log("u are choose Hero - Hunter");
                PlayerPrefs.SetInt("setMonkey", 1);
                break;
        }
    }

    public void GetPickedCharacter()
    {
        CharacterPicked = null;
        var characterIDChoosen = PlayerPrefs.GetInt(GlobalValue.ChoosenCharacterInstanceID, 0);
        foreach (var character in Characters)
        {
            var ID = character.GetInstanceID();
            if (ID == characterIDChoosen)
            {
                CharacterPicked = character;
                return;
            }
        }
    }
}
