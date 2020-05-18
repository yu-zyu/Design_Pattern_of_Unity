using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileProperties : FileIO
{
    public Dictionary<string, string> Properties { get; set; }

    
    public void readFromFile(string filename)
    {
        string filePath = Application.dataPath + @"\Resources\" + filename;
        string[] allText = File.ReadAllLines(filePath);
        Properties = new Dictionary<string, string>();
        foreach (var text_line in allText)
        {
            string[] key_and_value = text_line.Split(',');
            Properties.Add(key_and_value[0], key_and_value[1]);
        }
    }

    public void writeToFile(string filename)
    {
        string filePath = Application.dataPath + @"\Resources\" + filename;
        var encoding = System.Text.Encoding.GetEncoding("utf-8");
        var writer = new System.IO.StreamWriter(filePath, false, encoding);
        try
        {
            foreach (var propertie in Properties)
            {
                var record = string.Format(propertie.Key + "," + propertie.Value);
                writer.WriteLine(record);
            }
        }
        finally
        {
            writer.Close();
        }
    }

    public void setValue(string key, string value)
    {
        Properties[key] = value;
    }

    public string getValue(string key)
    {
        return Properties[key];
    }
}
