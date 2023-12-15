using UnityEngine;

public sealed class Hunter : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Rigidbody Rb => _rigidbody ??= GetComponent<Rigidbody>();
    
    private void Update()
    {
        var player = FindObjectOfType<MovePlayer>().transform;
        var direction = (player.position - transform.position).normalized;
        //transform.Translate(direction * 0.7f * Time.deltaTime);
        Rb.AddForce(direction * 0.12f);
        transform.LookAt(player);
    }
}
