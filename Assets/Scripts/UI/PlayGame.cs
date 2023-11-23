using UnityEngine;
using UnityEngine.SceneManagement;

namespace T_Scripts.UI
{
    public class PlayGame : MonoBehaviour
    {
        public GameObject ChengePlayerPanel;
        public void Play()
        {
            ChengePlayerPanel.SetActive(false);

            SceneManager.LoadScene("GameplayScene");
        }
        public void ExitGame()
        {
            PlayerPrefs.DeleteKey("PlayerChenge");

            Application.Quit();
        }
    }
}
