using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play1 : MonoBehaviour
{
    public GameObject ChengePlayerPanel;

    public GameObject ButtonAGrup1;

    public GameObject ButtonPlay2;

    private Button ButtonPlay2Script;

    public void ActivatePanet()
    {
        ChengePlayerPanel.SetActive(true);

        ButtonAGrup1.SetActive(false);

        ButtonPlay2Script = ButtonPlay2.GetComponent<Button>();

        ButtonPlay2Script.interactable = false;
    }

    public void DeactivatePanet()
    {
        ChengePlayerPanel.SetActive(false);

        ButtonAGrup1.SetActive(true);
    }
    public void ExitGame()
    {
        PlayerPrefs.DeleteKey("PlayerChenge");

        Application.Quit();
    }
}
