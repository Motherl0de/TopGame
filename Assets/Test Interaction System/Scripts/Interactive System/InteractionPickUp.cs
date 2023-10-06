using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPickUp : Interact
{
    
    public override void OnInteract(InteractorManager interactor,GameObject obj)
    {
        interactor.textT.text = interactor.textT.text+$"��'��� {obj.name} ������\n";
        obj.SetActive(false);
    }

    public InteractionPickUp(GameObject obj) : base(obj)
    {

    }
}
