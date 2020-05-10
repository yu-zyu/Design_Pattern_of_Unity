using UnityEngine;

public class Book : MonoBehaviour
{
    private string name;

    public Book(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }
    
}
