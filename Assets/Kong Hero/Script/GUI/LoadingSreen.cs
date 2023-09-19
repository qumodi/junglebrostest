using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingSreen : MonoBehaviour
{
    public static LoadingSreen Instance;

    [SerializeField] private Text loadingText;


    void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }

    void Start()
    {
        loadingText.text = Localisation.GetString("Loading");
    }

    public static void Show()
    {
        Instance.gameObject.SetActive(true);
    }
}
