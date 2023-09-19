using UnityEngine;
using System.Collections;

public class CheckerPauseGameScript : MonoBehaviour
{
    [SerializeField] private GameObject menuManager;

    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuManager.GetComponent<MenuManager>().Pause();
        }

    }

}
