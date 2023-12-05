using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DataManager : MonoBehaviour
{
    public GameObject ButtonZombie;

    public GameObject ButtonMonstr;
    public void ChengeMonstr()
    {
        PlayerPrefs.SetInt("PlayerChenge", 1);

        PlayerPrefs.Save();
               
    }

    public void ChengeZonbi()
    {
        PlayerPrefs.SetInt("PlayerChenge", 0);

        PlayerPrefs.Save();
    }
     
}
