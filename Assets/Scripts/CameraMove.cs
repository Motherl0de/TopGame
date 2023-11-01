using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 _initialRotation;
    private bool _isRotating = false;

    private void Start()
    {
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
        }
    }
}

