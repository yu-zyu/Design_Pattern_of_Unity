using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Display b1 = new StringDisplay("Hello, world.");
            Display b2 = new SideBorder(b1, '#');
            Display b3 = new FullBorder(b2);
            b1.show();
            b2.show();
            b3.show();
            Display b4 =
                new SideBorder(
                    new FullBorder(
                        new FullBorder(
                            new SideBorder(
                                new FullBorder(
                                    new StringDisplay("こんにちは。")
                                    ),
                                '*'
                              )
                           )
                        ),
                        '/'
                );
            b4.show();
        }
    }
}
