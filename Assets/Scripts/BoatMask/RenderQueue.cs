using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BoatMask
{
    public class RenderQueue : MonoBehaviour
    {
        [SerializeField]
        private Material _water;
        [SerializeField]
        private Material _boat;

        protected void Awake()
        {
            _water.renderQueue = 3000;
            _boat.renderQueue = 2000;
        }
    }
}
