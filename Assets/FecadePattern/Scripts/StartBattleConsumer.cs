using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FecadePattern
{
    public class StartBattleConsumer : MonoBehaviour
    {
        [SerializeField] private BattleFacade _battleFecade;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.F1))
            {
                _battleFecade.StartBattle();
            }
        }
    }
}
