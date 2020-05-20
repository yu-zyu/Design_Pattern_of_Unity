using UnityEngine;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();
        private Singleton()
        {
            Debug.Log("インスタンスを生成しました。");
        }
        
        public static Singleton getInstance()
        {
            return singleton;
        }
    }
}
