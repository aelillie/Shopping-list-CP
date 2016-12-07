using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Realms;

namespace ShoppingList_PartableLib
{
    public class ShoppingItem : RealmObject
    {
        [PrimaryKey]
        public string Name { get; set; }
        public string Category { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }
}
