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

        public ShoppingItem GetItem(string name)
        {
            return _realm.ObjectForPrimaryKey<ShoppingItem>(name); //Should be faster than LINQ
        }

        public bool SaveItem(ShoppingItem item)
        {
            using (var trans = _realm.BeginWrite())
            {
                _realm.Manage(item);
                trans.Commit();
            }
            return item.IsValid;
        }

        public bool DeleteItem(string name)
        {
            var item = GetItem(name);
            using (var trans = _realm.BeginWrite())
            {
                _realm.Remove(item);
                trans.Commit();
            }
            return !item.IsValid;
        }
    }
}
