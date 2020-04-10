using System;
using System.Runtime.InteropServices;

namespace TestDLL
{
    class Program
    {
        [DllImport("C:\\Users\\thela\\source\\repos\\953506\\term 2\\C#\\LR4\\DLL\\Win32\\Debug\\DLL.dll")]
        public static extern bool isPowOfTwo(int num);

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPowOfTwo(num));
        }
    }
}
