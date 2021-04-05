using url;

namespace pracprac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arr = urlify.replaceSpace(new char[] {'h','e','y',' ','t',' ','h','e','r','e','\0','\0','\0','\0','\0'},9);
        }
    }
}
