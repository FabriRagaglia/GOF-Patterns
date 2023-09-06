using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern 
{ 
    public class Hero : MonoBehaviour,Damageable
    {
        private IWeapon _weapon;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _weapon?.Attack();
            }
        }

        public void DoDamage(int damage)
        {
            Debug.Log($"Damage recived {damage}");
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }
    }
}
