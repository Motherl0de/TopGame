
using System;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Quaternion _initialRotation;
    private bool _isRotating = false;
    [SerializeField] private CameraFollow _cameraFollow;

    void Start () 
    {
        _initialRotation = transform.rotation;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _isRotating = true;
            _cameraFollow.enabled = false;
        }
        
        if (Input.GetMouseButtonUp(1))
        {
            _isRotating = false;
            _cameraFollow.enabled = true;
            transform.rotation = _initialRotation;
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
}