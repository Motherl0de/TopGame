using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum InteractionType { 
    None = 0,
    Open,
    PickUp };

public class InteractorManager : MonoBehaviour
{
    public Text textT;
    private InteractFactory interactFactory = new InteractFactory();

    private LinkedList<Interact> _potentialInteractions = new LinkedList<Interact>();
    public void OnTriggerDetected(bool entered,GameObject obj)
    {
        if (entered)
            AddPotentialInteraction(obj);
        else
            RemovePotentialInteraction(obj);
        
    }
    private void AddPotentialInteraction(GameObject obj)
    {
        try
        {
            IInteractive interactibleObject = obj.GetComponent<IInteractive>();
            Interact interact = interactFactory.GetInteract(obj, interactibleObject.Type);
            _potentialInteractions.AddFirst(interact);
        }
        catch (NullReferenceException)
        {
            Debug.LogWarning($"Object don't have IInteractive component!\nCheck if object {obj.name} has IInteractible component.");
        }
    }

    private void RemovePotentialInteraction(GameObject obj)
    {
        if (_potentialInteractions.Count == 0)
            return;
        _potentialInteractions.RemoveFirst();
    }

    

    public void OnInteractionButtonPressed()
    {
        if (_potentialInteractions.Count == 0)
            return;

        Interact interact = _potentialInteractions.First.Value;
        interact.OnInteract(this,interact.interactableObject);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteractionButtonPressed();
        }
    }
}
