using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _damage;

    private void Update()
    {
        transform.Translate(transform.forward * (_speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}