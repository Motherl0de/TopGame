using UnityEngine;

public class ForTestTakeDamag : MonoBehaviour
{
    //private Health health;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<Health>() != null)
        {
           other.gameObject.GetComponentInParent<Health>().TakeDamag(10);
        }
    }
}
