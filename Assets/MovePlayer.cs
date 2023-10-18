using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    [SerializeField]private Rigidbody rigidbody;

    public float speed = 10f;

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0f, z) * speed;

        movement = Vector3.ClampMagnitude(movement, speed);

        movement *= Time.fixedDeltaTime;

        rigidbody.AddForce(movement,ForceMode.Impulse);
    }


    void FixedUpdate()
    {

        Move();

        Debug.Log(rigidbody.velocity.magnitude);



    }

}

