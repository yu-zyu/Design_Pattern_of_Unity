using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AbstractFactoryPattern_factory_exercises;

namespace AbstractFactoryPattern_exercises
{
    public class Main : MonoBehaviour
    {

        private void Start()
        {
            string[] target_list = new string[2]
            {
                "AbstractFactoryPattern_listfactory_exercises.ListFactory",
                "AbstractFactoryPattern_tablefactory_exercises.TableFactory" 
            };

            Factory factory = Factory.getFactory(target_list[1]);
            Page page = factory.createYahooPage();
            page.output();
        }
    }
}
