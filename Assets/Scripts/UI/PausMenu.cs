using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausMenu : MonoBehaviour
{
    public bool PausGame;

    public GameObject PausGameMenu;

    public GameObject Player;

    public GameObject PausButton;
        
    public void Resum()
    {
        PausGameMenu.SetActive(false);

        Time.timeScale = 1.0f;

        PausGame = false;

        //Player.GetComponent<CameraLook>().enabled = true;

        PausButton.GetComponent<Button>().interactable = true;
    }

    public void Pause()
    {
        PausGameMenu.SetActive(true);

        Time.timeScale = 0f;

        PausGame = true;

        //Player.GetComponent<CameraLook>().enabled = false;

        PausButton.GetComponent<Button>().interactable = false;

    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;

        SceneManager.LoadScene("SceneMenu");
    }

 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausGame)
            {
                Resum();
            }
            else
            {
                Pause();
            }

        }
    }
}