using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern { 
    [CreateAssetMenu(menuName = "Abstract Factory/Weapons container")]
    public class WeaponsConfiguration : ScriptableObject
    {
        [SerializeField] private Weapon[] weapons;
        private Dictionary<string, Weapon> idWeapons;

        private void Awake()
        {
            idWeapons = new Dictionary<string, Weapon>();
            foreach (var weapon in weapons)
            {
                idWeapons.Add(weapon.id, weapon);
            }
        }

        public Weapon GetEnemyByID(string id)
        {
            if (!idWeapons.TryGetValue(id, out var weapon))
            {
                Debug.LogError($"The weapon {id} is not exist");
            }

            return weapon;
        }
    }
}
