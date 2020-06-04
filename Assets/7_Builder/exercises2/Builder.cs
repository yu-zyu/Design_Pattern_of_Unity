
namespace BuilderPattern_exercises2
{
    public abstract class Builder 
    {
        private bool initialized = false;

        public void makeTitle(string title)
        {
            if (!initialized)
            {
                BuildTitle(title);
                initialized = true;
            }
        }

        public void makeString(string str)
        {
            if (initialized)
            {
                BuildString(str);
            }
        }

        public void makeItems(string[] items)
        {
            if (initialized)
            {
                BuildItems(items);
            }
        }

        public void close()
        {
            if (initialized)
            {
                BuildDone();
            }
        }

        protected abstract void BuildTitle(string title);
        protected abstract void BuildString(string str);
        protected abstract void BuildItems(string[] items);
        protected abstract void BuildDone();
    }
}
