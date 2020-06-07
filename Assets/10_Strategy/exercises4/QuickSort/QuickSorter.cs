using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern_exercises4
{
    public class QuickSorter : Sorter
    {
        string[] data;

        public void sort(string[] data)
        {
            this.data = data;
            qsort(0, data.Length - 1);
        }

        private void qsort(int pre, int post)
        {
            int saved_pre = pre;
            int saved_post = post;

            string mid = data[(pre + post) / 2];

            do
            {
                while (data[pre].CompareTo(mid) < 0)
                {
                    pre++;
                }
                while (mid.CompareTo(data[post]) < 0)
                {
                    post--;
                }
                if (pre <= post)
                {
                    string tmp = data[pre];
                    data[pre] = data[post];
                    data[post] = tmp;
                    pre++;
                    post--;
                }
            } while (pre <= post);
            if(saved_pre < post)
            {
                qsort(saved_pre, post);
            }
            if(pre < saved_post)
            {
                qsort(pre, saved_post);
            }
        }

    }
}
