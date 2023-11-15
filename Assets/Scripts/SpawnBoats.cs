using System;
using System.Collections;
using System.IO.Enumeration;
using Unity.Mathematics;
using UnityEngine;

public class SpawnBoats : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Rigidbody Rb => _rigidbody ??= GetComponent<Rigidbody>();
    
    [SerializeField] private Transform _target;

    private void FixedUpdate()
    {
        Vector3 toTarget = (_target.position - transform.position).normalized;
        Vector3 force = Rb.mass * (toTarget * 3f - Rb.velocity) / 1f;
        transform.LookAt(toTarget);
        Rb.AddForce(force);
    }

    private IEnumerator OnCollisionStay(Collision other)
    {
        if (other.gameObject.name == "Terrain_02")
        {
            yield return new WaitForSeconds(3f);
            gameObject.SetActive(false);
        }
    }
}
