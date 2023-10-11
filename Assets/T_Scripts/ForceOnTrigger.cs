using System;
using UnityEngine;

namespace T_Scripts
{
    public class ForceOnTrigger : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            other.attachedRigidbody.AddForce(Vector3.up * 14.4f);

        }

        // private void OnCollisionStay(Collision other)
        // {Y = sin(k*t) * amplitude + water_depth
        //     if (other.gameObject.CompareTag("Player"))
        //     {
        //         other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 75f);
        //     }
        // }
    }
}
