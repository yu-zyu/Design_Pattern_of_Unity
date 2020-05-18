
namespace AdapterPattern_delegation
{
    public class PrintBanner : Print
    {
        private Banner banner;
        public PrintBanner(string str) 
        {
            this.banner = new Banner(str); 
        }

        public void printWeak()
        {
            banner.showWithParen();
        }

        public void printStrong()
        {
            banner.showWithAster();
        }
    }
}
