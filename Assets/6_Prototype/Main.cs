using UnityEngine;
using PrototypePattern_framework;

namespace PrototypePattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("a");
            Manager manager = new Manager();
            UnderlinePen upen = new UnderlinePen('~');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');
            manager.register("strong message", upen);
            manager.register("warning box", mbox);
            manager.register("slash box", sbox);
            //生成
            Product p1 = (Product)manager.create("strong message");
            p1.Use("Hello, world.");
            Product p2 = (Product)manager.create("warning box");
            p2.Use("Hello. world.");
            Product p3 = (Product)manager.create("slash box");
            p3.Use("Hello. world.");
        }
    }
}
