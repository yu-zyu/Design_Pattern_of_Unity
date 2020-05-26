using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern_game
{
    public class Memento
    {
        int money;
        ArrayList fruits;

        public int getMoney()
        {
            return money;
        }

        public Memento(int money)
        {
            this.money = money;
            this.fruits = new ArrayList();
        }

        public void addFruit(string fruit)
        {
            fruits.Add(fruit);
        }

        public ArrayList getFruits()
        {
            return (ArrayList)fruits.Clone();
        }
    }
}
