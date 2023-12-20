using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeBoolAnim : MonoBehaviour
{
    public Animator FraimAnimator;

    public void BollFalse()
    {
        FraimAnimator.SetBool("TakeDamag", false);
    }
}
