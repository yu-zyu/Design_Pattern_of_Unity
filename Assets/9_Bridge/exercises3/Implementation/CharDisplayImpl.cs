using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern_exercises3
{
    public class CharDisplayImpl : DisplayImpl
    {
        private char head;
        private char body;
        private char foot;

        public CharDisplayImpl(char head, char body, char foot)
        {
            this.head = head;
            this.body = body;
            this.foot = foot;
        }

        override public void rawOpen()
        {
            Debug.Log(head);
        }

        override public void rawPrint()
        {
            Debug.Log(body);
        }

        override public void rawClose()
        {
            Debug.Log(foot);
        }
    }
}
