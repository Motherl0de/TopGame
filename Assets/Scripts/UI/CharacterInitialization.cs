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

            if (playerChenge == 1)
            {
                Zombie.SetActive(false);

                Monstr.SetActive(true);
            }
            else
            {
                Zombie.SetActive(true);

                Monstr.SetActive(false);
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
