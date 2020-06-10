using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

namespace FlyweightPattern_exercises2
{
    public class Main : MonoBehaviour
    {
        private static BigString[] bsarray = new BigString[1000];
        
        void Start()
        {
            Debug.Log("共有した場合：");
            testAllocation(true);
            Debug.Log("共有しない場合：");
            testAllocation(false);
        }

        public static void testAllocation(bool shared)
        {
            for(int i = 0; i < bsarray.Length; i++)
            {
                bsarray[i] = new BigString("1212123", shared);
            }
            showMemory();
        }

        public static void showMemory()
        {
            Debug.Log("使用メモリ　= " + Profiler.GetTotalAllocatedMemoryLong());
        }
    }
}
