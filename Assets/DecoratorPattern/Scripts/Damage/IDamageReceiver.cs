using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public interface IDamageReceiver
    {
        public void ReceiveDamage(int damage, Color color);
    }
}
