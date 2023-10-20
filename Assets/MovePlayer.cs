using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;

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

        if (rigidbody.velocity.y < 0)
        {
            targetVelocity.y = rigidbody.velocity.y;
        }

        Vector3 velocity = rigidbody.velocity;

        Vector3 velocityChange = (targetVelocity - velocity);

        rigidbody.AddForce(velocityChange, ForceMode.Impulse);

    }
    void FixedUpdate()
    {
          Move();
    }
}
