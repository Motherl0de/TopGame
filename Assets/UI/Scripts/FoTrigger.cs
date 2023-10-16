using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Health>().TakeDamag(10);
    }

}
