using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour,IInteractive
{
    [SerializeField]
    private ItemSO _item;

    public string Name { get
        {
            return _item.name;
        } 
    }

    [SerializeField]
    private ItemType _type;
    public ItemType Type => _type;

    public void OnDisable()
    {
        Destroy(this.gameObject);
    }
}
