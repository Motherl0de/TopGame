using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject healthFill;
    public int startingHP = 100;
    public int currentHP;
    private float hpDecrementInterval = 1.0f;

    private float timer;
    public UnityEngine.UI.Image _image_health;
    
    private void DecrementHP(int amount)
    {
        currentHP -= amount;
        _image_health.fillAmount = currentHP / 100f;

        if (currentHP <= 0)
        {
            var player = FindObjectOfType<MovePlayer>().gameObject;
            Destroy(player);
           Debug.Log("Game Over");
        }
    }

    // public void TakeDamag(int Damag)
    // {
    //     currentHP += Damag;
    //
    //     healthFill.GetComponent<UnityEngine.UI.Image>().fillAmount = currentHP / 100f;
    //
    //     if (currentHP <= 0)
    //     {
    //         Destroy(gameObject);
    //     }
    // }
    private void Start()
    {
        currentHP = startingHP;

        timer = hpDecrementInterval;

        _image_health = healthFill.GetComponent<UnityEngine.UI.Image>();
    }
    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            DecrementHP(1);

            timer = hpDecrementInterval;
        }
    }

}
