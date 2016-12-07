using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList_PartableLib
{
    public class ShoppingItemManager
    {
        private ShoppingListRepository _repository;

        public ShoppingItemManager()
        {
            _repository = new ShoppingListRepository();
        }

        public ShoppingItem GetItem(string name)
        {
            return _repository.GetItem(name);
        }

        public IList<ShoppingItem> GetItems()
        {
            return _repository.GetItems().ToList();
        }

        public bool SaveItem(ShoppingItem item)
        {
            return _repository.SaveItem(item);
        }

        public bool DeleteItem(string name)
        {
            return _repository.DeleteItem(name);
        }
    }
}
