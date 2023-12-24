using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInitialization : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Monster;

    private void Awake()
    {
        if(PlayerPrefs.HasKey("PlayerChenge")) 
        {
            if(PlayerPrefs.GetString("PlayerChenge") == Zombie.name)
            {
                Zombie.SetActive(true);

                Monster.SetActive(false);
            }
            else if(PlayerPrefs.GetString("PlayerChenge") == Monster.name)
            {
                Zombie.SetActive(false);

                Monster.SetActive(true);
            }
        }
    }
}
