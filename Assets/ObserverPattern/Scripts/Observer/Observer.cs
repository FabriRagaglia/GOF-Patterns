using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatern
{
    public interface Observer
    {
        void Update(Subject subject);
    }
}
