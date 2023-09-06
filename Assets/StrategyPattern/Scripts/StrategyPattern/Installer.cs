using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private Hero _heroPrefab;
        [SerializeField] private Sword _swordPrefab;
        [SerializeField] private Bow _bowPrefab;

        [SerializeField] private bool _useSword;

        private void Awake()
        {
            var hero = Instantiate(_heroPrefab);
            var weapon = GetWeapon(hero.transform);
            hero.SetWeapon(weapon);
        }

        private IWeapon GetWeapon(Transform parent)
        {
            if (_useSword)
            {
                return Instantiate(_swordPrefab, parent);
            }

            return Instantiate(_bowPrefab, parent);
        }
    }
}
