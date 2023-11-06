using UnityEngine;

internal class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    
    private void LateUpdate()
    {
        transform.position = _target.position;
        transform.rotation = _target.rotation;
    }
}