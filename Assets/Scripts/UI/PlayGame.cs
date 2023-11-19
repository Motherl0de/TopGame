using UnityEngine;
using UnityEngine.SceneManagement;

namespace T_Scripts.UI
{
    public class PlayGame : MonoBehaviour
    {
        public void Play()
        {
            SceneManager.LoadScene("GameplayScene");
        }
        public void ExitGame()
        {
            PlayerPrefs.DeleteKey("PlayerChenge");

            Application.Quit();
        }
    }
}
