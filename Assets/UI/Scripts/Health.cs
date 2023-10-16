using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Health : MonoBehaviour
        
{

    public GameObject healthFill;
    public int _health;

    public int MaxHealth;

    public void TakeDamag(int Damag)
    {
        _health -= Damag;

        healthFill.GetComponent<UnityEngine.UI.Image>().fillAmount = (float)(_health / 100f);


        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
