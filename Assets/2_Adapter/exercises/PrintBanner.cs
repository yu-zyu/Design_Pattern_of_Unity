
namespace AdapterPattern_exercises

{
    public class PrintBanner : Banner, Print
    {
        public PrintBanner(string str) : base(str)
        {
            base.str = str;
        }

        public void printWeak()
        {
            showWithParen();
        }

        public void printStrong()
        {
            showWithAster();
        }
    }
}
