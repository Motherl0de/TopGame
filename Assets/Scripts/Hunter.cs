using System;
using UnityEngine;

public sealed class Hunter : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Animator _animator;
    private Health _health;
    private static readonly int Attack1 = Animator.StringToHash("attack");
    private Health health;
    private Animator Anim => _animator ??= GetComponent<Animator>();
    private Rigidbody Rb => _rigidbody ??= GetComponent<Rigidbody>();

    private void Start()
    {
        health = FindObjectOfType<Health>().GetComponent<Health>();
    }

    private void Update()
    {
        Move();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<MovePlayer>())
        {
            Anim.SetTrigger(Attack1);
            health.currentHP -= 15;
        }
    }

    private void Move()
    {
        var player = FindObjectOfType<MovePlayer>().transform;
        var direction = (player.position - transform.position).normalized;
        Rb.AddForce(direction * 1.9f);
        transform.LookAt(player);
    }
}
