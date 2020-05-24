using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class Player
    {
        private string name;
        private Strategy strategy;
        private int wincount;
        private int losecount;
        private int gamecount;
        public Player(string name, Strategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        public Hand nextHand()
        {
            return strategy.NextHand();
        }

        public void win()
        {
            strategy.Study(true);
            wincount++;
            gamecount++;
        }

        public void lose()
        {
            strategy.Study(false);
            losecount++;
            gamecount++;
        }

        public void even()
        {
            gamecount++;
        }

        public string toString()
        {
            return "[" + name + ":" + gamecount + " games, " + wincount + " win, " + losecount + " lose" + "]";
        }
    }
}
