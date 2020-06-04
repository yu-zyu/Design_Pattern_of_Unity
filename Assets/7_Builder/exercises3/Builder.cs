using Unity;
using UnityEngine;
namespace BuilderPattern_exercises3
{
    public interface Builder
    {
        void makeTitle(string title);
        void makeString(string str);
        void makeItems(string[] items);
        void close();
    }
}
