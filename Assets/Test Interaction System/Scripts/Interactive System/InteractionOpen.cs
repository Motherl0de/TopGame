using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionOpen : Interact
{

    public InteractionOpen(GameObject obj) : base(obj)
    {

    }
    public override void OnInteract(InteractorManager interactor, GameObject obj)
    {
        try
        {
            BoxItem item = obj.GetComponent<BoxItem>();
            item.isOpened = !item.isOpened;
            if (item.isOpened)
            {
                interactor.textT.text = interactor.textT.text + $"Ви закрили {obj.name}\n";
            }
            else
            {
                interactor.textT.text = interactor.textT.text + $"Ви відкрили {obj.name}\n";
            }
        }
        catch (NullReferenceException)
        {
            Debug.LogWarning($"Object don't have BoxItem component!\nCheck if object {obj.name} has BoxItem component.");
        }
    }


}
