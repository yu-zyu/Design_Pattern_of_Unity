using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern_exercises2
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            MultiStringDisplay md = new MultiStringDisplay();
            md.add("おはようございます。");
            md.add("こんにちは。");
            md.add("おやすみなさい、また明日。");
            md.show();

            Display d1 = new SideBorder(md, '#');
            d1.show();

            Display d2 = new FullBorder(md);
            d2.show();
        }
    }
}
