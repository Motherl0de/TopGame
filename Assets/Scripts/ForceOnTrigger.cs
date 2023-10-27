using UnityEngine;

public class ForceOnTrigger : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(Vector3.up * 14.4f);
    }
}