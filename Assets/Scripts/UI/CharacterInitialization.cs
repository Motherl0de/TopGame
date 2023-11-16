using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInitialization : MonoBehaviour
{
    public GameObject Zombie;

    public GameObject Monstr;
    private void Awake()
    {
        
        if(PlayerPrefs.HasKey("PlayerChenge"))
        {
            int playerChenge = PlayerPrefs.GetInt("PlayerChenge");

            if (playerChenge == 2)
            {
                Zombie.SetActive(false);

                Monstr.SetActive(true);

                Debug.Log(playerChenge);
            }
            else
            {
                Zombie.SetActive(true);

                Monstr.SetActive(false);

                Debug.Log(playerChenge);

            }

        }
        
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
