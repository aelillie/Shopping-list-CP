using System.Collections.Generic;
using System.Linq;
using Realms;

namespace ShoppingList_PartableLib
{
    public class ShoppingDatabase
    {
        private Realm _realm;
        public static ShoppingDatabase ShoppingDb => ShoppingDb ?? new ShoppingDatabase();

        private ShoppingDatabase()
        {
            _realm = Realm.GetInstance();
        }


        public IEnumerable<ShoppingItem> GetItems()
        {
            return _realm.All<ShoppingItem>().ToList();
        }

        public ShoppingItem GetItem(int id)
        {
            return _realm.All<ShoppingItem>().FirstOrDefault(); //TODO: Id og just name?
        }
    }
}
