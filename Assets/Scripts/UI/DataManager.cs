using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public void ChengeMonstr()
    {
        PlayerPrefs.SetInt("PlayerChenge", 2);

        PlayerPrefs.Save();

        Debug.Log("Chenge MONSTR");
    }

    public void ChengeZonbi()
    {
        PlayerPrefs.SetInt("PlayerChenge", 1);

        PlayerPrefs.Save();

        Debug.Log("Chenge ZOMBIE");
    }
     
}
