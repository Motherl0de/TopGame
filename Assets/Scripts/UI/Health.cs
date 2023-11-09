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

    public int startingHP = 100;

    public int currentHP;

    public int MaxHealth ;

    private float hpDecrementInterval = 1.0f;

    private float timer;
    private void DecrementHP(int amount)
    {
        currentHP -= amount;

        //Debug.Log("HP: " + currentHP);

        healthFill.GetComponent<UnityEngine.UI.Image>().fillAmount = currentHP/100f;

        if (currentHP <= 0)
        {
            // Здесь можно добавить дополнительные действия при достижении HP <= 0
            Debug.Log("Game Over");
        }
    }

    //public void TakeDamag(int Damag)
    //{
    //    currentHP -= Damag;

    //    healthFill.GetComponent<UnityEngine.UI.Image>().fillAmount = currentHP / 100f;

    //    if (currentHP <= 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    private void Start()
    {
        currentHP = startingHP;

        timer = hpDecrementInterval;
    }
    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            DecrementHP(1); // Отнимаем 1 HP

            timer = hpDecrementInterval; // Сбрасываем таймер
        }
    }

}
