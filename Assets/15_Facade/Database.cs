using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace FacadePattern_pagemaker
{
    public class Database
    {
        public Dictionary<string, string> Properties { get; set; }

        private Database()
        {

        }

        public static Dictionary<string, string> getProperties(string dbname)
        {
            string filePath = Application.dataPath + @"\Resources\" + dbname + ".txt";
            string[] allText = File.ReadAllLines(filePath);
            var Properties = new Dictionary<string, string>();
            foreach (var text_line in allText)
            {
                string[] key_and_value = text_line.Split(',');
                Properties.Add(key_and_value[0], key_and_value[1]);
            }

            return Properties;

//            properties            string filename = dbname + ".txt";
//            properties prop = new properties();
 //           try
  //          {
   //             prop.load(new FileInputStream(filename));
    //        }
     //       catch (IOException e)
      //      {
       //         Debug.Log("Warning: " + filename + " is not found.");
        //    }
         //   return prop;
        }
    }
}
