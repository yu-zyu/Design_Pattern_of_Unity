using UnityEngine;
using FactoryMethodPattern_exercises_framework;
using FactoryMethodPattern_exercises_idcard;


namespace FactoryMethodPattern_exercises
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.create("結城浩");
            Product card2 = factory.create("とむら");
            Product card3 = factory.create("佐藤花子");
            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}
