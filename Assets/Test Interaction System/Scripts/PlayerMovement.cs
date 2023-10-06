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

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        //_characterRigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime), ForceMode.Impulse);
        //_characterRigidbody.AddForce(transform.forward * speed);


        Vector3 targetVelocity = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))) * speed;

        // Apply a force that attempts to reach our target velocity
        Vector3 velocity = _characterRigidbody.velocity;
        Vector3 velocityChange = (targetVelocity - velocity);

        _characterRigidbody.AddForce(velocityChange, ForceMode.VelocityChange);
        //transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime));
    }
}
