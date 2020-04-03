using System;
using System.Numerics;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int counter = 0;
            BigInteger startValue=0, endValue=0, composition=1;
            do
            {
                Console.WriteLine("Введите начальное значение и конечное");
                startValue = Convert.ToUInt64(Console.ReadLine());
                endValue = Convert.ToUInt64(Console.ReadLine());
            }
            while (startValue>endValue);
           
            if (startValue % 2 == 1)
                startValue++;
            if (startValue != 0)
            {
                for (BigInteger value = startValue; value <= endValue; value += 2)
                {
                    BigInteger value0 = value;
                    while (value0 % 2 == 0)
                    {
                        value0 /= 2;
                        counter++;
                    }
                }
                Console.WriteLine($"Будет делиться на 2 в {counter} степени");

                // чтобы здесь был хоть какой-то смысл в использовании BigInteger, а не long я сделал второй вариант, но он очень медленный

                for (BigInteger value = startValue; value <= endValue; value += 2)
                    composition *= value;
                
                counter = 0;
                while (composition % 2 == 0)
                {
                    composition /= 2;
                    counter++;
                }
                Console.WriteLine($"Будет делиться на 2 в {counter} степени");
            }
            else
                Console.WriteLine("Будет делиться на 2 в бесконечной степени степени");

            // первым способом считает быстро до 10 в 7 степени, вторым - 10 в 5 считает уже секунд 30
        }
    }
}
