using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern { 
    public class FactoryInstaller : MonoBehaviour
    {
        [SerializeField] private EnemiesConfiguration _enemiesConfiguration;
        [SerializeField] private WeaponsConfiguration _weaponsConfiguration;
        
        private void Start()
        {
            var enemiesFactory = new EnemyFactory(Instantiate(_enemiesConfiguration));
            var weaponsFactory = new WeaponFactory(Instantiate(_weaponsConfiguration));

            var consumerGameObject = new GameObject();
            var consumer = consumerGameObject.AddComponent<Consumer>();
            consumer.Configure(new ObjectsFactory(enemiesFactory, weaponsFactory));
        }
    }
}
