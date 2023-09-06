using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Arrow : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void Awake()
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * _speed;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var hero = collision.GetComponent<Damageable>();
            hero?.DoDamage(10);
            Destroy(gameObject);
        }
    }
}
