
using System.Collections.Generic;

namespace DAOPattern
{
    public interface IItemDao
    {
        int GetCountItems();
        Items GetItem(int index);
        void AddItem(Items item);
    }
}

