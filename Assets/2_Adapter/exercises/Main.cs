using UnityEngine;

namespace AdapterPattern_exercises

{
    public class Main : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Print p = new PrintBanner("Hello");
            p.printWeak();
            p.printStrong();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
