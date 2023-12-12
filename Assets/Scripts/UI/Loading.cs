using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public GameObject CanvasLoading;

    private AsyncOperation async_operation;

    public Text TextProgress;

    public Slider Progress_Bar;
    public void Load()
    {
        CanvasLoading.SetActive(true);

        StartCoroutine(Async_load_COR());
    }
    IEnumerator Async_load_COR()
    {
        float LoadingProgress;

        async_operation = SceneManager.LoadSceneAsync(1);

        //async_operation.allowSceneActivation = false;

        while (!async_operation.isDone)
        {
            LoadingProgress = Mathf.Clamp01(async_operation.progress / 0.9f);

            TextProgress.text = $"Loading ... {(LoadingProgress * 100).ToString("0")}%";

            Progress_Bar.value = LoadingProgress;

            yield return null;
        }
        
    }
}
