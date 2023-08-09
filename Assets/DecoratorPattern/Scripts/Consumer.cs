using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class Consumer : MonoBehaviour
    {
        [SerializeField] private DamageReceiver _damageReceiver;
        private Attack _attack;
        private AttackerDecorator _fireAttacker;
        private AttackerDecorator _woodAttacker;
        private AttackerDecorator _fireAndWoodAttacker;


        void Awake()
        {
            var damage = 100;
            var fireDamage = 10;
            var woodDamage = 11;
            _attack = new Attack(damage);
            _fireAttacker = new FireAttackerDecorator(_attack, fireDamage);
            _woodAttacker = new WoodAttackerDecorator(_attack, woodDamage);
            _fireAndWoodAttacker = new FireAttackerDecorator(_woodAttacker, fireDamage);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                _attack.ExecuteAttack(_damageReceiver);
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                _fireAttacker.ExecuteAttack(_damageReceiver);
            }

            if (Input.GetKeyDown(KeyCode.F3))
            {
                _woodAttacker.ExecuteAttack(_damageReceiver);
            }

            if (Input.GetKeyDown(KeyCode.F4))
            {
                _fireAndWoodAttacker.ExecuteAttack(_damageReceiver);
            }
        }
    }
}
