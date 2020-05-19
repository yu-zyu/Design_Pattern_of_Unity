using UnityEngine;

namespace TemplateMethodPattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, world.");
            AbstractDisplay d3 = new StringDisplay("こんにちは");
            d1.display();
            d2.display();
            d3.display();
        }
    }
}
