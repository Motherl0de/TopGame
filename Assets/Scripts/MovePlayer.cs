using UnityEngine;
using UnityEngine.Serialization;


public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private readonly float _speed = 10f;
    [SerializeField] private float _rotationSpeed = 2.0f;
    private Animator _animator;
    private static readonly int Run = Animator.StringToHash("Run");
    private Animator Anim => _animator ??= GetComponent<Animator>();

    private void Move()
    {
        float z = Input.GetAxis("Vertical");
        
        if (z == 0) return;

        Anim.SetFloat(Run, z);

        Vector3 targetVelocity = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))) * _speed;

        if (_rigidbody.velocity.y < 0)
        {
            targetVelocity.y = _rigidbody.velocity.y;
        }
        
        Vector3 velocity = _rigidbody.velocity;
        Vector3 velocityChange = (targetVelocity - velocity);
        _rigidbody.AddForce(velocityChange, ForceMode.Impulse);
    }

    private void Rotate()
    {
        float x = Input.GetAxis("Horizontal");
        if (x == 0)
        {
            return;
        }
        transform.Rotate(0f,x * _rotationSpeed,0f);
    }
    void FixedUpdate()
    {
          Move();
          Rotate();
    }
}
