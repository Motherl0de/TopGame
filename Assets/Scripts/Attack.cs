using System;
using Unity.VisualScripting;
using UnityEngine;

public sealed class Attack : MonoBehaviour
{
    private Animator _animator;
    private Health _health;
    private Transform _hunterPosition;
    private AudioSource _attack;
    private AudioSource attack => _attack ??= GetComponent<AudioSource>();

    private Transform Hunter =>
        _hunterPosition ??= FindObjectOfType<Hunter>().GetComponent<Transform>();
    private Health Health => _health ??= FindObjectOfType<Health>();
    private static readonly int Attack1 = Animator.StringToHash("Attack");

    private Animator Anim => _animator ??= GetComponent<Animator>();

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Anim.SetBool(Attack1, true);
            attack.Play();
        }
        else
        {
            Anim.SetBool(Attack1, false);
        }

        if (Hunter)
        {
            if (Physics.Raycast(transform.position,Hunter.position,2f))
            {
                if(Input.GetMouseButtonDown(0))
                    Hunter.gameObject.GetComponent<Hunter>().Health(2);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<MoveTourist>()) Health.currentHP += 15;
        if (other.gameObject.CompareTag("Shrub")) Health.currentHP -= 20;
    }
}
