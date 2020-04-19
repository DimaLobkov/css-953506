using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _4._1
{
    class Program
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string Cmd, StringBuilder StrReturn, int ReturnLength, IntPtr HwndCallback);

        static void playWav(string fileName)
        {
            mciSendString("open \"" + fileName + "\" type waveaudio alias thisIsMyTag", null, 0, IntPtr.Zero);
            mciSendString("play thisIsMyTag from 0", null, 0, IntPtr.Zero);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to .wav file you want to open:");
            string fileName = Console.ReadLine();

            playWav(fileName);

            Console.WriteLine("Press any button to close the program");
            Console.ReadKey();
        }
    }
}