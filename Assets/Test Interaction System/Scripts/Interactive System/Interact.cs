using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interact 
{
    public GameObject interactableObject;
    public abstract void OnInteract(InteractorManager interactor, GameObject obj);
    public Interact(GameObject obj)
    {
        this.interactableObject = obj;
    }
}
