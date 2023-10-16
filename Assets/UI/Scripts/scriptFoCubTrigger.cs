using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFoCubTrigger : MonoBehaviour
{
    public GameObject player;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Health>())
        {
            Health health = other.gameObject.GetComponent<Health>();

            health.TakeDamag(10);

            Debug.Log(health._health);
        }

        Debug.Log("странный контакт");



    }
}
