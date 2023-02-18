using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private float _secondsBetweenShoot;

    private int _shootID = Animator.StringToHash("Shoot");
    private float _timeAfterLastShoot;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_timeAfterLastShoot >= _secondsBetweenShoot)
        {
            _animator.Play(_shootID);
            _weapon.Shoot();
            _timeAfterLastShoot = 0;
        }

        _timeAfterLastShoot += Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}
