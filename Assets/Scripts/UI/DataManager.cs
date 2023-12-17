using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataManager : MonoBehaviour
{
    public GameObject ButtonZombie;

    public GameObject ButtonMonstr;

    public Button ButtonPlayGame2;
    public void ChengeMonstr()
    {
        PlayerPrefs.SetInt("PlayerChenge", 1);

        PlayerPrefs.Save();

        ButtonPlayGame2.interactable = true;
               
    }

    public void ChengeZonbi()
    {
        PlayerPrefs.SetInt("PlayerChenge", 0);

        PlayerPrefs.Save();

        ButtonPlayGame2.interactable = true;
    }
     
}
