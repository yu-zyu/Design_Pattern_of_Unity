using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory;

namespace AbstractFactoryPattern
{
    public class Main : MonoBehaviour
    {

        private void Start()
        {
            string[] target_list = new string[2]
            {
                "AbstractFactoryPattern_listfactory.ListFactory",
                "AbstractFactoryPattern_tablefactory.TableFactory" 
            };


            Factory factory = Factory.getFactory(target_list[0]);

            Link asahi = factory.createLink("朝日新聞", "http://www.asahi.com/");
            Link yomiuri = factory.createLink("読売新聞", "http://www.yomiuri.com/");
            Link us_yahoo = factory.createLink("Yahoo!", "http://www.yahoo.com/");
            Link jp_yahoo = factory.createLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
            Link excite = factory.createLink("Excite", "http://www.excite.com/");
            Link google = factory.createLink("Google", "http://www.google.com/");

            Tray traynews = factory.createTray("新聞");
            traynews.add(asahi);
            traynews.add(yomiuri);

            Tray trayyahoo = factory.createTray("Yahoo!");
            trayyahoo.add(us_yahoo);
            trayyahoo.add(jp_yahoo);

            Tray traysearch = factory.createTray("サーチエンジン");
            traysearch.add(excite);
            traysearch.add(google);
            traysearch.add(trayyahoo);

            Page page = factory.createPage("LinkPage", "結城 浩");
            page.add(traynews);
            page.add(traysearch);
            page.output();
        }
    }
}
