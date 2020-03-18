namespace Blog.Dal
{
    public class ContextBase
    {
        protected static DatabaseContext context;

        private static object _lock = new object();
        
        public ContextBase()
        {
            createContext();
        }

        private static void createContext()
        {
            if (context == null)
            {
                lock (_lock)
                {
                    context = new DatabaseContext();
                }

            }
        }
    }
}
