using System;
using UnityEngine;

namespace T_Scripts
{
    public class DestroyWoodenBox : MonoBehaviour
    {
        [SerializeField] private GameObject _woodBox1;
        [SerializeField] private GameObject _woodBox2;
        [SerializeField] private GameObject _woodBox3;

        private void Update()
        {
            if (_woodBox1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    _woodBox1.SetActive(false);
                    _woodBox2.SetActive(true);
                }
            }
            else if(_woodBox2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    _woodBox2.SetActive(false);
                    _woodBox3.SetActive(true);
                }
            }
            
        }
    }
}
