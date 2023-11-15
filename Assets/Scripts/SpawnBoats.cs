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
        transform.LookAt(_target);
        Rb.AddForce(force);
        
    }
}
