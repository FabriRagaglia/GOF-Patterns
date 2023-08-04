using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern { 
    public class WeaponFactory 
    {
        private readonly WeaponsConfiguration _weaponsConfigfuration;

        public WeaponFactory(WeaponsConfiguration weaponsConfiguration)
        {
            _weaponsConfigfuration = weaponsConfiguration;
        }

        public Weapon Create(string id)
        {
            var weapon = _weaponsConfigfuration.GetEnemyByID(id);
            return Object.Instantiate(weapon);
        }
    }
}
