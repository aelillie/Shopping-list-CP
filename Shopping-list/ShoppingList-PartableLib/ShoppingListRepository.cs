using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList_PartableLib
{
    public class ShoppingListRepository
    {
        private ShoppingDatabase _db;
        public ShoppingListRepository()
        {
            _db = ShoppingDatabase.ShoppingDb;
        }
        public ShoppingItem GetItem(string name)
        {
            return _db.GetItem(name);
        }

        public IEnumerable<ShoppingItem> GetItems()
        {
            return _db.GetItems();
        }

        public bool SaveItem(ShoppingItem item)
        {
            return _db.SaveItem(item);
        }

        public bool DeleteItem(string name)
        {
            return _db.DeleteItem(name);
        }
    }
}
