using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _characterRigidbody;
    public float speed = 10f;
    
    void Start()
    {

    }
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        if (deltaX == 0 && deltaZ == 0)
            return; 
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);


        Vector3 targetVelocity = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))) * speed;

        Vector3 velocity = _characterRigidbody.velocity;
        Vector3 velocityChange = (targetVelocity - velocity);

        _characterRigidbody.AddForce(velocityChange, ForceMode.VelocityChange);
    }
}
