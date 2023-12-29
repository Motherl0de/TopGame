using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;
    private float scalingDuration = 1f;
    public GameObject BackToMainMenu;

    public void GameOverCat()
    {
        GameOverPanel.SetActive(true);
        StartCoroutine(ScaleOverTime());
    }

    IEnumerator ScaleOverTime()
    {
        float elapsedTime = 0f;
        Vector3 initialScale = new Vector3(0.01f, 0.01f, 0.01f);
        Vector3 targetScale = Vector3.one;

        while (elapsedTime < scalingDuration)
        {
            GameOverPanel.GetComponent<RectTransform>().localScale = Vector3.Lerp(initialScale, targetScale, (elapsedTime / scalingDuration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        GameOverPanel.GetComponent<RectTransform>().localScale = targetScale;

        BackToMainMenu.SetActive(true);

    }
}
