using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataManager : MonoBehaviour
{
    public Button ButtonPlayGame2;
    public void ChengePlayer2(int player)
    {
        if( player == 0 )
        {
            PlayerPrefs.SetString("PlayerChenge", "Zombie");
        }
        else if ( player == 1)
        {
            PlayerPrefs.SetString("PlayerChenge", "sk_monster_4");
        }
        PlayerPrefs.Save();

        ButtonPlayGame2.interactable = true;
    }

}
