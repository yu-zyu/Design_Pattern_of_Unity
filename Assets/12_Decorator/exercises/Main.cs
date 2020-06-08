using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern_exercises
{
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Display b1 = new StringDisplay("Hello, world.");
            Display b2 = new UpDownBorder(b1, '-');
            Display b3 = new SideBorder(b2, '*');
            b1.show();
            b2.show();
            b3.show();
            Display b4 =
                new FullBorder(
                    new UpDownBorder(
                        new SideBorder(
                            new UpDownBorder(
                                new SideBorder(
                                    new StringDisplay("こんにちは。"),
                                    '*'
                                ),
                                '='
                            ),
                            '|'
                        ),
                        '/'
                    )
                );
            b4.show();
        }
    }
}
