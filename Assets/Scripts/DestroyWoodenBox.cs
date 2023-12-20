using System;
using UnityEngine;

public sealed class DestroyWoodenBox : MonoBehaviour
{
    [SerializeField] private GameObject[] _box;
    [SerializeField] private GameObject _partical;
    [SerializeField] private Transform _spawn;
    [SerializeField] private AudioSource _audioPortal;
    [SerializeField] private ParticleSystem _portal;
    private GameObject _current;
    private GameObject _next;
    private int _pendingIndex;

    private void Awake()
    {
        _current = _box[0];
        _next = _box[1];
        _pendingIndex = 2;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<MovePlayer>()) BreakOnClick();
    }

    private void BreakOnClick()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _pendingIndex <= _box.Length)
        {
            _current.SetActive(false);
            if (_next is not null)
            {
                _next.SetActive(true);
                Instantiate(_partical, _spawn);
                if (_next == _box[2].activeInHierarchy) {
                    _audioPortal.Play();
                    Instantiate(_portal,new Vector3(-9f,9.1f,-10f),Quaternion.identity);
                }
            }

            _current = _next;
            _next = _pendingIndex < _box.Length ? _box[_pendingIndex] : null;
            _pendingIndex++;
            
        }
    }
}