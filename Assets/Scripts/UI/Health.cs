using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int startingHP = 100;
    public int currentHP;
    private float timerDecrimentalInterval = 1.0f;
    public Slider healthBarSlyder;
    public Image FraimDamag;
    public Animator FraimAnimator;
    
    private void DecrementHP(int amount)
    {
        if(currentHP > 0)
        {
            currentHP -= amount;

            healthBarSlyder.value = currentHP / 100f;
        }
         
        if (currentHP <= 0)
        {
            //var player = FindObjectOfType<MovePlayer>().gameObject;
            //Destroy(player);
            Debug.Log($"Game Over = {currentHP}");
        }
    }
    public void TakeDamag(int Damag)
    {
        currentHP -= Damag;

        if(currentHP <= 0) 
        {
            currentHP = 0;

            Debug.Log("Game Over");
        }
        healthBarSlyder.value = currentHP / 100f;

        FraimAnimator.SetBool("TakeDamag", true);
    }
    public void BollFalse()
    {
        FraimAnimator.SetBool("TakeDamag", false);
    }
    private void Start()
    {
        currentHP = startingHP;
    }
    private void Update()
    {
        timerDecrimentalInterval -= Time.deltaTime;

        if (timerDecrimentalInterval <= 0f)
        {
            DecrementHP(1);

            timerDecrimentalInterval = 1.0f;
        }
    }
}
