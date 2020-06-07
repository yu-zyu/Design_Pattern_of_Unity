using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace AbstractFactoryPattern_factory_exercises
{
    public abstract class Factory
    {
        public static Factory getFactory(string classname)
        {
            Factory factory = null;
            Type type = Type.GetType(classname);
            try
            {
                factory = (Factory)Activator.CreateInstance(type);
            }
            catch(Exception e)
            {
                 Debug.Log(e.StackTrace.ToString());
            }
            return factory;
        }

        public abstract Link createLink(string caption, string url);
        public abstract Tray createTray(string caption);
        public abstract Page createPage(string title, string author);
        public Page createYahooPage()
        {
            Link link = createLink("Yahoo!", "http://www.yahoo.com/");
            Page page = createPage("Yahoo!", "Yahoo!");
            page.add(link);
            return page;
        }
    }
}
