using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractFactory 
{
    public Interact GetInteract(GameObject obj, ItemType type)
    {
        switch (type)
        {
            case ItemType.Picked:
                return new InteractionPickUp(obj);
            case ItemType.OpenClose:
                return new InteractionOpen(obj);
        }
        return null;
    }
}
