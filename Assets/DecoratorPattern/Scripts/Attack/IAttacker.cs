using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public interface IAttacker
    {
        public void ExecuteAttack(IDamageReceiver damageReceiver);
    }
}
