using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern_game
{
    public class Gamer
    {
        private int money;
        private ArrayList fruits = new ArrayList();
        private System.Random random = new System.Random();
        private static string[] fruitsname =
        {
            "リンゴ", "ぶどう", "バナナ", "みかん",
        }; 

        public Gamer(int money)
        {
            this.money = money;
        }

        public int getMoney()
        {
            return money;
        }

        public void bet()
        {
            int dice = random.Next(6) + 1;
            if(dice == 1)
            {
                money += 100;
                Debug.Log("所持金が増えました。");
            } else if(dice == 2)
            {
                money /= 2;
                Debug.Log("所持金が半分になりました。");
            } else if(dice == 6)
            {
                string f = getFruit();
                Debug.Log("フルーツ(" + f + ")をもらいました。");
                fruits.Add(f);
            }
            else
            {
                Debug.Log("何も起こりませんでした。");
            }
        }

        public Memento createMemento()
        {
            Memento m = new Memento(money);
            IEnumerator it = fruits.GetEnumerator();
            while (it.MoveNext())
            {
                string f = (string)it.Current;
                if (f.StartsWith("おいしい"))
                {
                    m.addFruit(f);
                }
            }
            return m;
        }

        public void restoreMemento(Memento memento)
        {
            this.money = memento.getMoney();
            this.fruits = memento.getFruits();
        }

        public string toString()
        {
            return "[money = " + money + ", fruits = " + fruits + "]";
        }

        private string getFruit()
        {
            string prefix = "";
            if (random.Next(2) == 0)
            {
                prefix = "おいしい";
            }
            return prefix + fruitsname[random.Next(fruitsname.Length)];
        }

        
    }
}
