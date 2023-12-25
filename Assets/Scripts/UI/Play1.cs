using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play1 : MonoBehaviour
{
    public GameObject ButtonPlay2;

    public void OffInteractiv()
    {
        ButtonPlay2.GetComponent<Button>().interactable = false;
    }
    public void ExitGame()
    {
        PlayerPrefs.DeleteKey("PlayerChenge");

        Application.Quit();
    }
    private void Start()
    {
        ButtonPlay2.GetComponent<Button>().interactable = false;
    }
}
