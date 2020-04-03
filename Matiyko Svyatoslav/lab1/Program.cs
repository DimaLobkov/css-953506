using System;


class Example
{
    static void Main()
    {
Console.WriteLine("Введите выражение:");

string expression = Console.ReadLine();

char[] split_symb = {'+','-','*','/'};
char[] split_num = {'0','1','2','3','4','5','6','7','8','9'};

string[] str_numbers = expression.Split(split_symb);
string[] str_symbols = expression.Split(split_num,StringSplitOptions.RemoveEmptyEntries);


int size_num=0;
int size_symb=0;

foreach(string m in str_numbers)
{    
    size_num++;
}

int[] arr_numbers = new int[size_num];

for(int i=0;i<size_num;i++)
{
arr_numbers[i]=Int32.Parse(str_numbers[i]);
}


foreach(string s in str_symbols)
{
    size_symb++;
}

    // производим операции 
    for (int i = 0; i < size_symb; i++)
    {
        if (str_symbols[i] == "*"|| str_symbols[i] == "/")
        {
           
            arr_numbers[i]=  (str_symbols[i] == "*") ? (arr_numbers[i] * arr_numbers[i + 1])   :   (arr_numbers[i] / arr_numbers[i + 1]);

            //сдвигаем массив чисел влево на 1 
            for (int n = i + 1; n < size_num; n++)
            {
                if(n==size_num-1)
                {
                    break;
                }
                arr_numbers[n] = arr_numbers[n + 1];
                
                
            }
            size_num--;

            //сдвигаем массив знаков влево на 1 
            for (int j =  i; j < size_symb; j++)
            {
                if(j==size_symb-1)
                {
                    break;
                }
                str_symbols[j] = str_symbols[j + 1];
            }
            size_symb--;
            i = 0;

            if(size_symb==1)
            {
                arr_numbers[0] = (str_symbols[0] == "*") ? (arr_numbers[0] * arr_numbers[1]) : (arr_numbers[0] / arr_numbers[1]);
            }
        }
    }
    

    for (int i = 0; i < size_symb; i++)
    {

        if (str_symbols[0] == "+" || str_symbols[0] == "-")
        {
            
            arr_numbers[i] = (str_symbols[i] == "+") ? (arr_numbers[i] + arr_numbers[i + 1]) : (arr_numbers[i] - arr_numbers[i + 1]);
            
            //сдвигаем массив чисел влево на 1 
            for (int n = i + 1; n < size_num; n++)
            {
                if(n==size_num-1)
                {
                    break;
                }
                arr_numbers[n] = arr_numbers[n + 1];
                
            }
            size_num--;

            //сдвигаем массив знаков влево на 1 
            for (int j = i; j < size_symb; j++)
            {
                if(j==size_symb-1)
                {
                    break;
                }
                str_symbols[j] = str_symbols[j + 1];
            }
            size_symb--;
            i = 0;
            if(size_symb==1)
            {
                            arr_numbers[0] = (str_symbols[0] == "+") ? (arr_numbers[0] + arr_numbers[1]) : (arr_numbers[0] - arr_numbers[1]);
 
             }
        }
    }

    Console.WriteLine(arr_numbers[0]);  
    Console.ReadLine();
    }
    }