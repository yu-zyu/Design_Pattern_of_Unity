using UnityEngine;

namespace SingletonPattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Start");
            Singleton obj1 = Singleton.getInstance();
            Singleton obj2 = Singleton.getInstance();
           if(obj1 == obj2)
            {
                Debug.Log("*obj1とobj2は同じインスタンスです。*");
            }
            else
            {
                Debug.Log("*obj1とobj2は同じインスタンスではありません。*");
            }
            Debug.Log("*End.*");
        }
    }
}
