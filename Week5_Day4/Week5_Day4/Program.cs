namespace Week5_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int reverse_num = Int32Extention.Mirror1(num);
            Console.WriteLine(reverse_num);

            //------------

            string str = "Ibtisam";
            string reverse_str = StringExtention.Mirror2(str);
            Console.WriteLine(reverse_str);
        }
    }
}
