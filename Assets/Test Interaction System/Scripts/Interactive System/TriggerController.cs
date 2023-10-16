using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyEvent : UnityEvent<bool, GameObject> { }
public class TriggerController : MonoBehaviour
{
    [SerializeField] private MyEvent _enterZone = default;
    [SerializeField] private LayerMask _layers = default;
    private void OnTriggerEnter(Collider other)
    {
        if ((1 << other.gameObject.layer & _layers) != 0)
        {
            _enterZone.Invoke(true, other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if ((1 << other.gameObject.layer & _layers) != 0)
        {
            _enterZone.Invoke(false, other.gameObject);
        }
    }
}
