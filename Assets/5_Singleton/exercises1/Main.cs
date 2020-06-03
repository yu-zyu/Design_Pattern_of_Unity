using UnityEngine;

namespace SingletonPattern_exercises1
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Start");
            for(int i = 0; i < 10; i++)
            {
                Debug.Log(i + ":" + TicketMaker.getInstance().getNextTicketNumber());
            }
            Debug.Log("End.");
        }
    }
}
