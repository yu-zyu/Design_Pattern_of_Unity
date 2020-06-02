using System.Collections.Generic;
using FactoryMethodPattern_exercises_framework;

namespace FactoryMethodPattern_exercises_idcard
{
    public class IDCardFactory : Factory 
    {
        private Dictionary<int, string> database = new Dictionary<int, string>();
        private int serial = 100;

        override protected Product createProduct(string owner)
        {
            return new IDCard(owner, serial++);
        }
        
        override protected void registerProduct(Product product)
        {
            IDCard card = (IDCard)product;
            database.Add(card.getSerial(), ((IDCard)product).getOwner());
        }

        public Dictionary<int, string> getOwners()
        {
            return database;
        }
    }
}
