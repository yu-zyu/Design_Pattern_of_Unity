using System.Collections.Generic;
using FactoryMethodPattern_framework;

namespace FactoryMethodPattern_idcard
{
    public class IDCardFactory : Factory 
    {
        private List<string> owners = new List<string>();
        override protected Product createProduct(string owner)
        {
            return new IDCard(owner);
        }
        
        override protected void registerProduct(Product product)
        {
            owners.Add(((IDCard)product).getOwner());
        }

        public List<string> getOwners()
        {
            return owners;
        }
    }
}
