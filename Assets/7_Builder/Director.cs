using UnityEngine;

namespace BuilderPattern
{
    public class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void construct()
        {
            builder.makeTitle("Greeting");
            builder.makeString("朝から昼にかけて");
            builder.makeItems(new string[]{
                "おはようございます。",
                "こんにちは。",
            });
            builder.makeString("夜に");
            builder.makeItems(new string[] {
               "こんばんは。",
               "おやすみなさい。",
                "さようなら。",
            });
            builder.close();
        }
    }
}
