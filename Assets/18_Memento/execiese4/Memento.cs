using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;

namespace MementoPattern_game_exercises4
{
    [DataContract]
    public class Memento
    {
        [DataMember]
        int money;
        [DataMember]
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
