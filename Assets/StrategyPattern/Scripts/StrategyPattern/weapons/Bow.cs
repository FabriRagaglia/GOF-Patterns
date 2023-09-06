using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class Bow : MonoBehaviour, IWeapon
    {
        [SerializeField] private GameObject _arrowPrefab;
        [SerializeField] private Transform _spawnReference;

        public void Attack()
        {
            var arrow = Instantiate(_arrowPrefab, _spawnReference.position, _spawnReference.rotation);
        }
    }
}
