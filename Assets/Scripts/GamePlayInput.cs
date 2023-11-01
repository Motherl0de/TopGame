using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayInput
{
    [SerializeField] private event Action<Vector2> _rotationInput;
}
