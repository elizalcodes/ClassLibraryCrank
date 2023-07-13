namespace ClassLibraryCrank
{
    public class SomeClass
    {
        public static string Method1(string name, int length)
        {

            if (name.Length > length)
            {
                return name.Substring(0, length) + "...";
            }
            else
            {
                return name;
            }
        }

        public static string Method2(string str)
        {
            if (str.Length > 10)
            {
                return "hello";
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(10);
                }

                return "bye";
            }
        }
    }
}