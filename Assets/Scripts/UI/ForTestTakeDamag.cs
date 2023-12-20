using UnityEngine;

public class ForTestTakeDamag : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {

        other.gameObject.GetComponentInParent<Health>().TakeDamag(10)
            ;

        //if (other.gameObject.GetComponentInParent<Health>() != null)
        //{
        //   other.gameObject.GetComponentInParent<Health>().TakeDamag(10);
        //}
    }
}
