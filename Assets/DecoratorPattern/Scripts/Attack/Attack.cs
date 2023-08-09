using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class Attack : IAttacker
    {
        private readonly int _damage;

        public Attack(int damage)
        {
            _damage = damage;
        }

        public void ExecuteAttack(IDamageReceiver damageReceiver)
        {
            damageReceiver.ReceiveDamage(_damage, Color.white);
        }
    }
}
