using System;
using UnityEngine;

public sealed class Hunter : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Animator _animator;
    private Health _health;
    private static readonly int Attack1 = Animator.StringToHash("attack");
    private Health health;
    private Transform _player;
    private Animator Anim => _animator ??= GetComponent<Animator>();
    private Rigidbody Rb => _rigidbody ??= GetComponent<Rigidbody>();

    private void Start()
    {
        health = FindObjectOfType<Health>().GetComponent<Health>();
        _player = FindObjectOfType<MovePlayer>().transform;
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
        var direction = (_player.position - transform.position).normalized;
        Rb.AddForce(direction * 9f);
        transform.LookAt(_player);
    }
}
