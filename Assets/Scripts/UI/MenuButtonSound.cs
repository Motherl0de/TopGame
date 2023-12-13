using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuButtonSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource audioSorce;

    public AudioClip audioButton;

    public AudioClip audioButtonClick;

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(audioSorce != null && audioButton != null)
        {
            audioSorce.PlayOneShot(audioButton);
        }

    }
    public void Click2222()
    {
        if (audioSorce != null && audioButtonClick != null)
        {
            audioSorce.PlayOneShot(audioButtonClick);
        }



    }
        
}
