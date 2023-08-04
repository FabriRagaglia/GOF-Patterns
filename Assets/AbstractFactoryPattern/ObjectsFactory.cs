using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern { 
    public class ObjectsFactory
    {
        private readonly EnemyFactory _enemyFactory;
        private readonly WeaponFactory _weaponFactory;

        public ObjectsFactory(EnemyFactory enemyFactory, WeaponFactory weaponFactory)
        {
            _enemyFactory = enemyFactory;
            _weaponFactory = weaponFactory;
        }

        public Enemy CreateEnemy(string enemyID)
        {
            return _enemyFactory.Create(enemyID);
        }

        public Weapon CreateWeapon(string weaponID)
        {
            return _weaponFactory.Create(weaponID);
        }
    }
}