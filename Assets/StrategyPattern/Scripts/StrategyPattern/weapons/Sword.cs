using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class Sword : MonoBehaviour, IWeapon
    {
        [SerializeField] private Transform _damageZoneCenter;
        [SerializeField] private float _damageZoneRadius;
        private readonly Collider2D[] _hitColliders = new Collider2D[10];

        public void Attack()
        {
            var size = Physics2D.OverlapCircleNonAlloc(_damageZoneCenter.position, _damageZoneRadius, _hitColliders);

            for (int i = 0; i < size; i++)
            {
                var hitCollider = _hitColliders[i];
                var hero = hitCollider.GetComponent<Damageable>();
                hero?.DoDamage(10);
            }
        }
    }
}

