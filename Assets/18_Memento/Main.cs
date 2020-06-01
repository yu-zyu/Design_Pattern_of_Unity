using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using MementoPattern_game;

namespace MementoPattern
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Gamer gamer = new Gamer(100);
            Memento memento = gamer.createMemento();
            for (int i = 0; i < 100; i++) 
            {
                Debug.Log("====" + i);
                Debug.Log("現状:" + gamer);

                gamer.bet();

                Debug.Log("所持金は" + gamer.getMoney() + "円になりました。");

                if(gamer.getMoney() > memento.getMoney())
                {
                    Debug.Log("    (だいぶ増えたので、現在の状態を保存しておこう)");
                    memento = gamer.createMemento();
                }else if(gamer.getMoney() < memento.getMoney() / 2)
                {
                    Debug.Log("    (だいぶ減ったので、以前の状態に復帰しよう) ");
                    gamer.restoreMemento(memento);
                }

                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception)
                {

                }
                Debug.Log("");
            }
        }
    }
}
