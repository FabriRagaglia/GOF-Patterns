using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAOPattern {
    public class ItemController : MonoBehaviour, IItemDao
    {
        private List<Items> _items = new();

        public void AddItem(Items item)
        {
            _items.Add(item);
        }

        public int GetCountItems()
        {
            return _items.Count;
        }

        public Items GetItem(int index)
        {
            if (index >= _items.Count) return null;

            return _items[index];
        }
    }
}

