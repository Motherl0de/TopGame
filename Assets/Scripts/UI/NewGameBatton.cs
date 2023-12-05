using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameBatton : MonoBehaviour
{
    public GameObject ChengePlayerPanel;

    public GameObject ButtonNewGame;

    public GameObject ButtonExitGame;

    public void ActivatePanet()
    {
        ChengePlayerPanel.SetActive(true);

        ButtonNewGame.SetActive(false);

        ButtonExitGame.SetActive(false);
    }

    public void DeactivatePanet()
    {
        ChengePlayerPanel.SetActive(false);

        ButtonNewGame.SetActive(true);

        ButtonExitGame.SetActive(true);
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
