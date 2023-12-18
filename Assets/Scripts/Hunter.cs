using System;
using UnityEngine;

public sealed class Hunter : MonoBehaviour
{
    [SerializeField] private ParticleSystem _attack1;
    [SerializeField] private ParticleSystem _attack2;
    private Rigidbody _rigidbody;
    private Animator _animator;
    private Health _health;
    private static readonly int Attack1 = Animator.StringToHash("attack");
    private Health health;
    private Transform _player;
    private int _curentHP = 50;
    private Animator Anim => _animator ??= GetComponent<Animator>();
    private Rigidbody Rb => _rigidbody ??= GetComponent<Rigidbody>();
    

    private void Start()
    {
        health = FindObjectOfType<Health>().GetComponent<Health>();
        _player = FindObjectOfType<MovePlayer>().transform;
    }

    private void Update()
    {
        if(_player)
            Move();
        if(_curentHP <= 0) Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<MovePlayer>())
        {
            Anim.SetTrigger(Attack1);
            health.currentHP -= 15;
            _attack1.Play();
            _attack2.Play();
        }
        else {
            _attack1.Stop();
            _attack2.Stop();
        }
    }

    private void Move()
    {
        var direction = (_player.position - transform.position).normalized;
        Rb.AddForce(direction * 9f);
        transform.LookAt(_player);
    }

    public int Health(int hp)
    {
        _curentHP -= hp;
        return _curentHP;
    }
}
