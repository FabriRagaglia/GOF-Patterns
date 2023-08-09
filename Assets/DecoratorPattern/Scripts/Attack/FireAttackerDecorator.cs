using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class FireAttackerDecorator : AttackerDecorator
    {
        private readonly int _fireDamage;

        public FireAttackerDecorator(IAttacker attacker, int fireDamage) : base(attacker)
        {
            _fireDamage = fireDamage;
        }

        public override void ExecuteAttack(IDamageReceiver damageReceiver)
        {
            base.ExecuteAttack(damageReceiver);
            damageReceiver.ReceiveDamage(_fireDamage, Color.red);
        }
    }
}
