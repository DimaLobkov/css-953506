using System;

namespace Laba3
{  
    class Program
    {
        static void Main(string[] args)
        {
            int kolv, uchenik; ;
            char numer;
            Console.WriteLine("Сколько студентов в группе? ");
            int.TryParse(Console.ReadLine(), out kolv);
            Gruppa chel = new Gruppa(kolv + 1);
            for (int i = 0; i < kolv; i++)
            {
                
                Console.WriteLine($"\nНомер студента: {i+1}");
                chel[i] = new Human { };
                chel[i].name = chel.GetName();
                chel[i].surname = chel.GetSurname();
                chel[i].age = chel.GetAge();
                chel[i].math = chel.GetMath();
                chel[i].rus = chel.GetRus();
                chel[i].phys = chel.GetPhys();
                chel[i].srb = chel.GetSrb();
                Console.Clear();
            }
            chel[kolv] = new Human { };
            do
            {
                Console.WriteLine("1-вывод всех студентов\n2-повысить/понизить балл студента по предметам\n3-распределение студентов по убыванию среднего балла\n4-отчислить студента\n0-Exit");
                numer = Console.ReadKey().KeyChar;

                switch (numer)
                {
                    case '1':
                        Console.Clear();
                        for (int i = 0; i < kolv; i++)
                        {
                            chel[i].GetInfo();
                            Console.WriteLine("\n");
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine($"Выберите номер ученика ");
                        int.TryParse(Console.ReadLine(), out uchenik);
                        chel[uchenik - 1].GetIzmena();
                        if (chel[uchenik - 1].math <= 0 || chel[uchenik - 1].rus <= 0 || chel[uchenik - 1].math <= 0)
                        {
                            chel[uchenik - 1].GetOtchislenie();
                        }
                        break;
                    case '3':
                        Console.Clear();
                        for (int i = 0; i < kolv; i++)
                        {
                            for (int y = 0; y < kolv - 1; y++)
                            {
                                if (chel[y].srb < chel[y + 1].srb)
                                {
                                    chel[kolv + 1] = chel[y];
                                    chel[y] = chel[y + 1];
                                    chel[y + 1] = chel[kolv + 1];
                                }
                            }
                        }
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine($"Выберите номер ученика ");
                        int.TryParse(Console.ReadLine(), out uchenik);
                        chel[uchenik - 1].GetOtchislenie();
                        break;
                    case '0':
                        return;
                }
            } while (true) ;

        }
    }
}
