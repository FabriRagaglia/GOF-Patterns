using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern { 
    public class EnemyFactory
    {
        private readonly EnemiesConfiguration _enemyConfiguration;

        public EnemyFactory(EnemiesConfiguration enemyConfiguration)
        {
            _enemyConfiguration = enemyConfiguration;
        }

        public Enemy Create(string id)
        {
            var enemy = _enemyConfiguration.GetEnemyByID(id);
            return Object.Instantiate(enemy);
        }
    }
}
