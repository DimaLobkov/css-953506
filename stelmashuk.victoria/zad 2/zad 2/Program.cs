using System;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Эта программа выводит текущую дату и время в двух форматах и рассчитывает количество нулей, единиц, ..., девяток в их записи. ");
            Console.WriteLine("Формат записи текущей даты и времени в России: ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("dd.MM.yyyy HH:mm:ss	"));
            //расчет количества чисел по отдельности от 0 до 9 в первом формате записи 
            var str = now.ToString("dd.MM.yyyy HH:mm:ss	");
            var numeral0 = "0";
            int i0 = 0, count0 = 0;
            while ((i0 = str.IndexOf(numeral0, i0)) != -1) {
                ++count0; i0 += numeral0.Length;
            }
            Console.WriteLine("Количество 0 в этой записи: ");
            Console.WriteLine(count0);
            var numeral1 = "1";
            int i1 = 0, count1 = 0;
            while ((i1 = str.IndexOf(numeral1, i1)) != -1) { 
                ++count1; i1 += numeral1.Length; 
            }
            Console.WriteLine("Количество 1 в этой записи: ");
            Console.WriteLine(count1);
            var numeral2 = "2";
            int i2 = 0, count2 = 0;
            while ((i2 = str.IndexOf(numeral2, i2)) != -1) { 
                ++count2; i2 += numeral2.Length;
            }
            Console.WriteLine("Количество 2 в этой записи: ");
            Console.WriteLine(count2);
            var numeral3 = "3";
            int i3 = 0, count3 = 0;
            while ((i3 = str.IndexOf(numeral3, i3)) != -1) { 
                ++count3; i3 += numeral3.Length;
            }
            Console.WriteLine("Количество 3 в этой записи: ");
            Console.WriteLine(count3);
            var numeral4 = "4";
            int i4 = 0, count4 = 0;
            while ((i4 = str.IndexOf(numeral4, i4)) != -1) { 
                ++count4; i4 += numeral4.Length;
            }
            Console.WriteLine("Количество 4 в этой записи: ");
            Console.WriteLine(count4);
            var numeral5 = "5";
            int i5 = 0, count5 = 0;
            while ((i5 = str.IndexOf(numeral5, i5)) != -1) {
                ++count5; i5 += numeral5.Length; 
            }
            Console.WriteLine("Количество 5 в этой записи: ");
            Console.WriteLine(count5);
            var numeral6 = "6";
            int i6 = 0, count6 = 0;
            while ((i6 = str.IndexOf(numeral6, i6)) != -1) {
                ++count6; i6 += numeral6.Length; 
            }
            Console.WriteLine("Количество 6 в этой записи: ");
            Console.WriteLine(count6);
            var numeral7 = "7";
            int i7 = 0, count7 = 0;
            while ((i7 = str.IndexOf(numeral7, i7)) != -1) { 
                ++count7; i7 += numeral7.Length;
            }
            Console.WriteLine("Количество 7 в этой записи: ");
            Console.WriteLine(count7);
            var numeral8 = "8";
            int i8 = 0, count8 = 0;
            while ((i8 = str.IndexOf(numeral8, i8)) != -1) { 
                ++count8; i8 += numeral8.Length;
            }
            Console.WriteLine("Количество 8 в этой записи: ");
            Console.WriteLine(count8);
            var numeral9 = "9";
            int i9 = 0, count9 = 0;
            while ((i9 = str.IndexOf(numeral9, i9)) != -1) { 
                ++count9; i9 += numeral9.Length; 
            }
            Console.WriteLine("Количество 9 в этой записи: ");
            Console.WriteLine(count9);
            //расчет количества чисел по отдельности от 0 до 9 во втором формате записи 
            Console.WriteLine("Формат записи текущей даты и времени в США: ");
            Console.WriteLine(now.ToString("MM-dd-yyyy hh:mm:ss	"));
            var str2 = now.ToString("MM-dd-yyyy hh:mm:ss");
            var numeral20 = "0";
            int i20 = 0, count20 = 0;
            while ((i20 = str2.IndexOf(numeral20, i20)) != -1) { 
                ++count20; i20 += numeral20.Length; 
            }
            Console.WriteLine("Количество 0 в этой записи: ");
            Console.WriteLine(count20);
            var numeral21 = "1";
            int i21 = 0, count21 = 0;
            while ((i21 = str2.IndexOf(numeral21, i21)) != -1) {
                ++count21; i21 += numeral21.Length; 
            }
            Console.WriteLine("Количество 1 в этой записи: ");
            Console.WriteLine(count21);
            var numeral22 = "2";
            int i22 = 0, count22 = 0;
            while ((i22 = str2.IndexOf(numeral22, i22)) != -1) {
                ++count22; i22 += numeral22.Length;
            }
            Console.WriteLine("Количество 2 в этой записи: ");
            Console.WriteLine(count22);
            var numeral23 = "3";
            int i23 = 0, count23 = 0;
            while ((i23 = str2.IndexOf(numeral23, i23)) != -1) { 
                ++count23; i23 += numeral23.Length; 
            }
            Console.WriteLine("Количество 3 в этой записи: ");
            Console.WriteLine(count23);
            var numeral24 = "4";
            int i24 = 0, count24 = 0;
            while ((i24 = str2.IndexOf(numeral24, i24)) != -1) { 
                ++count24; i24 += numeral24.Length; 
            }
            Console.WriteLine("Количество 4 в этой записи: ");
            Console.WriteLine(count24);
            var numeral25 = "5";
            int i25 = 0, count25 = 0;
            while ((i25 = str2.IndexOf(numeral25, i25)) != -1) {
                ++count25; i25 += numeral25.Length;
            }
            Console.WriteLine("Количество 5 в этой записи: ");
            Console.WriteLine(count25);
            var numeral26 = "6";
            int i26 = 0, count26 = 0;
            while ((i26 = str2.IndexOf(numeral26, i26)) != -1) { 
                ++count26; i26 += numeral26.Length;
            }
            Console.WriteLine("Количество 6 в этой записи: ");
            Console.WriteLine(count26);
            var numeral27 = "7";
            int i27 = 0, count27 = 0;
            while ((i27 = str2.IndexOf(numeral27, i27)) != -1) { 
                ++count27; i27 += numeral27.Length; 
            }
            Console.WriteLine("Количество 7 в этой записи: ");
            Console.WriteLine(count27);
            var numeral28 = "8";
            int i28 = 0, count28 = 0;
            while ((i28 = str2.IndexOf(numeral28, i28)) != -1) {
                ++count28; i28 += numeral28.Length;
            }
            Console.WriteLine("Количество 8 в этой записи: ");
            Console.WriteLine(count28);
            var numeral29 = "9";
            int i29 = 0, count29 = 0;
            while ((i29 = str2.IndexOf(numeral29, i29)) != -1) { 
                ++count29; i29 += numeral29.Length;
            }
            Console.WriteLine("Количество 9 в этой записи: ");
            Console.WriteLine(count29);
        }
    }
}
