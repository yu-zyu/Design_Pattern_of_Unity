using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;

namespace SingletonPattern_exercises1
{
    public class TicketMaker
    {
        private static int ticket = 1000;
        private static TicketMaker singleton = new TicketMaker();

        private TicketMaker()
        {
        }

        public static TicketMaker getInstance()
        {
            return singleton;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public int getNextTicketNumber()
        {
            return ticket++;
        }
    }
}
