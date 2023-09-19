using UnityEngine;
using System.Collections;

public class CheckerPauseScript : MonoBehaviour
{
    [SerializeField] private GameObject panelConfirmQuit;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelConfirmQuit.SetActive(true);
        }
    }
}
