using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouse : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Rigidbody Rb => _rigidbody ?? GetComponent<Rigidbody>();
    void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector3 targetVelocity = transform.TransformDirection(0f, 0f, Input.GetAxis("Vertical")) * 7f;
        if (Rb.velocity.y < 0)
        {
            targetVelocity.y = Rb.velocity.y;
        }
        float r = Input.GetAxis("Mouse X");
        transform.Rotate(0f,r * 6f,0f);
        Vector3 velocity = Rb.velocity;
        Vector3 velocityChange = (targetVelocity - velocity);
        Rb.AddForce(velocityChange, ForceMode.Impulse);
    }
}
