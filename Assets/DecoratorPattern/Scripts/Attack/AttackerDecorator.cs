using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public abstract class AttackerDecorator : IAttacker
    {
        private readonly IAttacker _attacker;

        protected AttackerDecorator(IAttacker attacker)
        {
            _attacker = attacker;
        }

        public virtual void ExecuteAttack(IDamageReceiver damageReceiver)
        {
            _attacker.ExecuteAttack(damageReceiver);
        }
    }
}
