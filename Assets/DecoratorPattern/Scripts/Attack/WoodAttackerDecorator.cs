using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class WoodAttackerDecorator : AttackerDecorator
    {
        private readonly int _woodDamage;

        public WoodAttackerDecorator(IAttacker attacker, int woodDamage) : base(attacker)
        {
            _woodDamage = woodDamage;
        }

        public override void ExecuteAttack(IDamageReceiver damageReceiver)
        {
            base.ExecuteAttack(damageReceiver);
            damageReceiver.ReceiveDamage(_woodDamage, Color.green);
        }
    }
}
