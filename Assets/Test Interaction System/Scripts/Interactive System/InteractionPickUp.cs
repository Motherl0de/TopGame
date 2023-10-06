using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPickUp : Interact
{
    
    public override void OnInteract(InteractorManager interactor,GameObject obj)
    {
        interactor.textT.text = interactor.textT.text+$"Об'єкт {obj.name} піднято\n";
        obj.SetActive(false);
    }

    public InteractionPickUp(GameObject obj) : base(obj)
    {

    }
}
