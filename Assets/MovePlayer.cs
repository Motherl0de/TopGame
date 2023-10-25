using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    public float speed = 10f;

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        if (x == 0 && z == 0)
        {
            return;
        }

        Vector3 targetVelocity = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))) * speed;

        if (_rigidbody.velocity.y < 0)
        {
            targetVelocity.y = _rigidbody.velocity.y;
        }

        Vector3 velocity = _rigidbody.velocity;

        Vector3 velocityChange = (targetVelocity - velocity);

        _rigidbody.AddForce(velocityChange, ForceMode.Impulse);

    }
    void FixedUpdate()
    {
          Move();
    }
}
