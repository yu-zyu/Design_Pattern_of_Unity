using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern
{
    public class Main:MonoBehaviour
    {
        void Start()
        {
            int seed1 = int.Parse("1");
            int seed2 = int.Parse("2");
            Player player1 = new Player("Taro", new WinningStrategy(seed1));
            Player player2 = new Player("Hana", new ProbStrategy(seed2));
            for(int i = 0; i < 10000; i++)
            {
                Hand nextHand1 = player1.nextHand();
                Hand nextHand2 = player2.nextHand();
                if (nextHand1.isStrongerThan(nextHand2))
                {
                    Debug.Log("Winner:" + player1);
                    player1.win();
                    player2.lose();
                }else if (nextHand2.isStrongerThan(nextHand1))
                {
                    Debug.Log("Winner;" + player2);
                    player1.lose();
                    player2.win();
                }
                else
                {
                    Debug.Log("Even...");
                    player1.even();
                    player2.even();
                }
            }
            Debug.Log("Total result:");
            Debug.Log(player1.toString());
            Debug.Log(player2.toString());
        }
    }
}
