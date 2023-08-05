using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FecadePattern
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] _alliesToSpawn;
        [SerializeField] private GameObject[] _enemiesToSpawn;

        private List<GameObject> _alliesSpawned = new();
        private List<GameObject> _enemiesSpawned = new();

        public void SpawnAllies()
        {
            foreach (var ally in _alliesToSpawn)
            {
                var allyInstance = Instantiate(ally);
                _alliesSpawned.Add(allyInstance);
            }
        }

        public void DestroyAllies()
        {
            foreach (var ally in _alliesSpawned)
            {
                Destroy(ally);
            }

            _alliesSpawned.Clear();
        }

        public void SpawnEnemies()
        {
            foreach (var enemy in _enemiesToSpawn)
            {
                var enemyInstance = Instantiate(enemy);
                _enemiesSpawned.Add(enemyInstance);
            }
        }

        public void DestroyEnemies()
        {
            foreach (var ally in _enemiesSpawned)
            {
                Destroy(ally);
            }

            _enemiesSpawned.Clear();
        }
    }
}
