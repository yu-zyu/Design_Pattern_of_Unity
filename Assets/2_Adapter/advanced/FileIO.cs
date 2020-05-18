using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface FileIO
{
 Dictionary<string, string> Properties
  {
        get;
        set;
   } 
    void readFromFile(string filename);
    void writeToFile(string filename);
    void setValue(string key, string value);
    string getValue(string key); 
}
