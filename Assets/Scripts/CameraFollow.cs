using System.Linq;
using UnityEngine;

internal class CameraFollow : MonoBehaviour
{
    private Transform _target;
    private Transform Target => _target ??= FindObjectsOfType<CameraTarget>().First(t => t.enabled).transform;
    
    private void LateUpdate()
    {
        transform.position = Target.position;
        transform.rotation = Target.rotation;
    }
}