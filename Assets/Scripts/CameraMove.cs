using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 _initialRotation;
    private bool _isRotating = false;
    [SerializeField] private Transform _target;
    private Vector3 offset;  

    void Start () 
    {        
        offset = transform.position - _target.position;
        _initialRotation = transform.rotation.eulerAngles;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _isRotating = true;
        }
        
        if (Input.GetMouseButtonUp(1))
        {
            _isRotating = false;
            transform.eulerAngles = _initialRotation;
        }

        if (_isRotating)
        {
            float rotationSpeed = 2.0f;
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

            transform.Rotate(Vector3.up, mouseX);
            transform.Rotate(Vector3.left, mouseY);
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.z = 0;
            transform.eulerAngles = currentRotation;
        }
    }
    void LateUpdate () 
    {        
        transform.position = _target.position + offset;
    }
}

