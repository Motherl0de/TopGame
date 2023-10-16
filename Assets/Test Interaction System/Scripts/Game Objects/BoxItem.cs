using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxItem : MonoBehaviour, IInteractive
{
    public bool isOpened;

    [SerializeField]
    private ItemType _type;
    public ItemType Type => _type;
}
