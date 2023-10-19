
using UnityEngine;

namespace T_Scripts
{
    public class DestroyWoodenBox : MonoBehaviour
    {
        [SerializeField]private GameObject[] _box;
        GameObject _current;
        GameObject _next;
        int _index;

        void Awake()
        {
            _current = _box[0];
            _next = _box[1];
            _index = 2;
        }

        void Update()
        {
            //It's code must be in OnColliderStay()
            if (Input.GetMouseButtonDown(0) && _index <= _box.Length)
            {
                _current.SetActive(false);
                if (_next is not null)
                {
                    _next.SetActive(true);
                }
                _current = _next;
                _next = _index < _box.Length ? _box[_index] : null;
                _index++;
            }
        }
    }
}
