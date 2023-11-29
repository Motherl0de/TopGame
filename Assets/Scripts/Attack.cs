using System;
using Unity.VisualScripting;
using UnityEngine;

public sealed class Attack : MonoBehaviour
{
    private Animator _animator;
    private Health _health;
    private Health Health => _health ??= FindObjectOfType<Health>();
    private static readonly int Attack1 = Animator.StringToHash("Attack");

    private Animator Anim => _animator ??= GetComponent<Animator>();

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Anim.SetBool(Attack1, true);
        }
        else
        {
            Anim.SetBool(Attack1, false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<MoveTourist>())
        {
            Anim.SetBool(Attack1, true);
            Health.currentHP += 15;
        }
    }
}
