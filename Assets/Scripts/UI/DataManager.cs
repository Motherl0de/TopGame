using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
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
