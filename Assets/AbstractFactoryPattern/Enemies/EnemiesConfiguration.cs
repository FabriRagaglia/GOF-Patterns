using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern { 
    [CreateAssetMenu(menuName = "Abstract Factory/Enemies container")]
    public class EnemiesConfiguration : ScriptableObject
    {
        [SerializeField] private Enemy [] enemies;
        private Dictionary<string, Enemy> idEnemies;

        private void Awake()
        {
            idEnemies = new Dictionary<string, Enemy>();
            foreach (var enemy in enemies)
            {
                idEnemies.Add(enemy.id, enemy);
            }
        }

        public Enemy GetEnemyByID(string id)
        {
            if(!idEnemies.TryGetValue(id, out var enemy))
            {
                Debug.LogError($"The enemy {id} is not exist");
            }

            return enemy;
        }
    }
}
