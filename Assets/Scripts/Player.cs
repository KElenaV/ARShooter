using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _secondsBetweenShoot;

    private float _timeAfterLastShoot;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}
