using UnityEngine;

public class ForDevelopers : MonoBehaviour
{
    public GameObject developerPanel;

    public void DeveloperPanetOn()
    {
        developerPanel.SetActive(true);

    }

    public void DeveloperPanetOff()
    {
        developerPanel.SetActive(false);

    }
}
