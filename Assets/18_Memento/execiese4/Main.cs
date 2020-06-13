using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using MementoPattern_game_exercises4;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace MementoPattern_exercises4
{
    public class Main : MonoBehaviour
    {
        public static string SAVEFILENAME;
        private void Start()
        {
            SAVEFILENAME = Application.dataPath + @"\Resources\game.dat";
            Gamer gamer = new Gamer(100);
            Memento memento = loadMemento();
            if (memento != null)
            {
                Debug.Log("前回保存した結果からスタートします。");
                gamer.restoreMemento(memento);
            }
            else
            {
                Debug.Log("新規にスタートします。");
                memento = gamer.createMemento();
            }
            for (int i = 0; i < 100; i++)
            {
                Debug.Log("====" + i);
                Debug.Log("現状:" + gamer);

                gamer.bet();

                Debug.Log("所持金は" + gamer.getMoney() + "円になりました。");

                if (gamer.getMoney() > memento.getMoney())
                {
                    Debug.Log("    (だいぶ増えたので、現在の状態を保存しておこう)");
                    memento = gamer.createMemento();
                    saveMemento(memento);
                }
                else if (gamer.getMoney() < memento.getMoney() / 2)
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

        public static void saveMemento(Memento memento)
        {
           // MemoryStream m = new MemoryStream();
           //     var serializera = new DataContractJsonSerializer(typeof(Memento));
           //     serializera.WriteObject(m, memento);

           //     m.Position = 0;
           //     StreamReader reader = new StreamReader(m);
           //     Debug.Log("リーダー　"+reader.ReadToEnd());


            try
            {
                using (var ms = new FileStream(SAVEFILENAME, FileMode.Create))
                {
                    var serializer = new DataContractJsonSerializer(typeof(Memento));
                    serializer.WriteObject(ms, memento);
                //    var a = Encoding.UTF8.GetString(ms.ToArray());
                //    using (var fs = new FileStream(SAVEFILENAME, FileMode.Create))
                //    {
                //        StreamWriter sw = new StreamWriter(fs);
                //        sw.WriteLine(a);

                //    }
                }
                //                objectOutput out = new objectOutputStream(new FileOutputStream(SAVEFILENAME));
                //                outwriteObject(memento);
                //                out.close();
            }
            catch (Exception e)
            {
                Debug.Log(e.StackTrace.ToString());
            }
        }

        public static Memento loadMemento()
        {
            Memento memento = null;
            try
            {
                using (var ms = new FileStream(SAVEFILENAME,FileMode.Open,FileAccess.Read))
                {
                    var serializer = new DataContractJsonSerializer(typeof(Memento));
                    memento = (Memento)serializer.ReadObject(ms);
                }
                // objctInput in = new objectInputStream(new FileInputStream(SAVEFILENAME);
                //     memento = (Memento)in.readObject();
                //     in.close();
            }
            catch (Exception e)
            {
                Debug.Log(e.StackTrace.ToString());
            }
            return memento;
        }
    }
}
