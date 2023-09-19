using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu_World : MonoBehaviour
{
    public int worldNumber = 1;
    public GameObject Locked;

    [SerializeField] private Text lockedText;

    void Start()
    {
        var worldreached = PlayerPrefs.GetInt(GlobalValue.WorldReached, 1);
        if (worldNumber <= worldreached)
            Locked.SetActive(false);
        else
        {
            Locked.SetActive(true);
            GetComponent<Button>().interactable = false;
        }

        lockedText.text = Localisation.GetString("Locked");
    }

    public void OpenWorld()
    {
        MainMenuHomeScene.Instance.OpenWorld(worldNumber);
    }
}
