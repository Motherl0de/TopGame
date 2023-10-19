
using System;
using UnityEngine;

namespace T_Scripts
{
    public class DestroyWoodenBox : MonoBehaviour
    {
        [SerializeField] private GameObject[] _box;
        [SerializeField] private GameObject _partical;
        [SerializeField] private Transform _spawn;
        private GameObject _current;
        private GameObject _next;
        private int _index;

        private void Awake()
        {
            _current = _box[0];
            _next = _box[1];
            _index = 2;
        }

        private void Update()
        {
            BreakOnClick();
        }

        private void OnCollisionStay(Collision other)
        {
            BreakOnClick();
        }

        private void BreakOnClick()
        {
            if (Input.GetMouseButtonDown(0) && _index <= _box.Length)
            {
                _current.SetActive(false);
                if (_next is not null)
                {
                    _next.SetActive(true);
                    Instantiate(_partical, _spawn);
                }

                _current = _next;
                _next = _index < _box.Length ? _box[_index] : null;
                _index++;
            }
        }
    }
}
