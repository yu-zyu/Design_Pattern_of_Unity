using UnityEngine;

namespace AdapterPattern_extends
{
    public class Banner
    {
        private protected string str;

        public Banner(string str)
        {
            this.str = str;
        }

        public void showWithParen()
        {
            Debug.Log("(" + str + ")");
        }

        public void showWithAster()
        {
            Debug.Log("*" + str + "*");
        }
    }
}
