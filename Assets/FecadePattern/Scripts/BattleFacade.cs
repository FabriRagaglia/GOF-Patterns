using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FecadePattern
{
    public class BattleFacade : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;
        [SerializeField] private HeroUI _heroUI;
        [SerializeField] private UIFade _uiFade;

        public void StartBattle()
        {
            _uiFade.Show();
            _spawner.SpawnAllies();
            _spawner.SpawnEnemies();
            _heroUI.ShowAlliesUI();
            _heroUI.ShowEnemiesUI();
        }

        public void EndBattle()
        {
            _spawner.DestroyAllies();
            _spawner.DestroyEnemies();
            _heroUI.HideAlliesUI();
            _heroUI.HideEnemiesUI();
            _uiFade.Hide();
        }
    }
} 
