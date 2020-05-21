using System.Collections.Generic;
using UnityEngine;
namespace PrototypePattern_framework
{
    public class Manager 
    {
        private Dictionary<string, Product> showcase = new Dictionary<string, Product>();
        public void register(string name, Product proto)
        {
            showcase.Add(name, proto);
        }

        public Product create(string protoname)
        {
            Debug.Log(showcase[protoname]);
            Product p = (Product)showcase[protoname];
            return (Product)p.Clone();
        }
    }
}
