using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DAOPattern {
    public class DAOConsumer : MonoBehaviour
    {
        [SerializeField] private IItemDao _itemDao;

        private void Start()
        {
            if(!TryGetComponent(out _itemDao))
            {
                _itemDao = gameObject.AddComponent<ItemController>();
            }

            var item1 = new Items();
            item1.Id = 1244;
            item1.Name = "Item 1";
            _itemDao.AddItem(item1);

            var item2 = new Items();
            item2.Id = 236;
            item2.Name = "Item 2";
            _itemDao.AddItem(item2);

            var item3 = new Items();
            item3.Id = 3424;
            item3.Name = "Item 3";
            _itemDao.AddItem(item3);

            var item4 = new Items();
            item4.Id = 4424;
            item4.Name = "Item 4";
            _itemDao.AddItem(item4);

            var item5 = new Items();
            item5.Id = 5424;
            item5.Name = "Item 5";
            _itemDao.AddItem(item5);

            var item6 = new Items();
            item6.Id = 6424;
            item6.Name = "Item 6";
            _itemDao.AddItem(item1);

 
        }

        private void Update()
        {
            //Use for call item information
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetItemInformation();
            }
        }

        private void GetItemInformation()
        {
            var countItemList = _itemDao.GetCountItems();
            Debug.Log($"count item list {countItemList}");

            var randomIndex = Random.Range(0, countItemList);
            Debug.Log($"Random value {randomIndex}");

            var item = _itemDao.GetItem(randomIndex);
            Debug.Log($"item with index {randomIndex}. name: {item.Name} id: {item.Id}");
        }
    }
}
