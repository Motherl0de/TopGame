using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private Transform _player;

    public float _sensitivity = 10f;

    private bool _isRMBPressed;
    void Start()
    {

    }

    void Update()
    {
        OnCameraMove(new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")), true);
        _isRMBPressed = true;
    }

    private void OnCameraMove(Vector2 cameraMovement, bool isDeviceMouse)
    {
        if (isDeviceMouse && !_isRMBPressed)
            return;
        //додати обмеження кута повороту
        float deviceMultiplier = isDeviceMouse ? 0.2f : Time.deltaTime;
        float cameraEngleX = _camera.transform.eulerAngles.x - cameraMovement.y * deviceMultiplier * _sensitivity;
        if (cameraEngleX < 85)
            cameraEngleX = Mathf.Clamp(cameraEngleX, -85, 85);
        else if (cameraEngleX >= 270)
            cameraEngleX = Mathf.Clamp(cameraEngleX, 360 - 85, 360);
        _camera.transform.rotation = Quaternion.Euler(cameraEngleX, _camera.transform.eulerAngles.y, 0);
        _player.transform.rotation = Quaternion.Euler(0, _player.transform.eulerAngles.y + cameraMovement.x * deviceMultiplier * _sensitivity, 0);

    }
}
