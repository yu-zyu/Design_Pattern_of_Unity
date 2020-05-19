using UnityEngine;

namespace FactoryMethodPattern_framework
{
    public abstract class Factory
    {
        public Product create(string owner)
        {
            Product p = createProduct(owner);
            registerProduct(p);
            return p;
        }

        protected abstract Product createProduct(string owner);
        protected abstract void registerProduct(Product product);
    }
}
