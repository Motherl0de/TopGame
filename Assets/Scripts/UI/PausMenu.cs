using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausMenu : MonoBehaviour
{
    private bool PausGame;
    public GameObject PausGameMenu;
    public GameObject Player;
    public void Resum()
    {
        PausGameMenu.SetActive(false);

        Time.timeScale = 1.0f;

        PausGame = false;
               
        Player.GetComponentInChildren<MovePlayer>().enabled = true;

        Player.GetComponentInChildren<CameraMove>().enabled = true;
    }

    public void Pause()
    {
        PausGameMenu.SetActive(true);

        Time.timeScale = 0f;

        PausGame = true;

        Player.GetComponentInChildren<MovePlayer>().enabled = false;

        Player.GetComponentInChildren<CameraMove>().enabled = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;

        SceneManager.LoadScene("MainMenuScene");

        PlayerPrefs.DeleteKey("PlayerChenge");
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
