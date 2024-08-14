using System;
using System;
using System.Collections.Generic;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (int i = 3; i * i <= n; i += 2) // tăng 2 giá trị
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static void Main()
    {
        int a, b;
        Console.WriteLine("Nhập số a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số b: ");
        b = int.Parse(Console.ReadLine());

        // Xử lý trường hợp a > b bằng cách hoán đổi các giá trị
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        List<int> primeNumbers = new List<int>();
        for (int i = a; i <= b; i++)
        {
            if (IsPrime(i) && IsPrime(SumOfDigits(i)))
            {
                primeNumbers.Add(i);
            }
        }

        for (int i = 0; i < primeNumbers.Count; i++)
        {
            Console.Write(primeNumbers[i] + " ");
            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
            }
        }

        // Thêm một dòng mới vào cuối nếu tổng số không phải là bội số của 10
        if (primeNumbers.Count % 10 != 0)
        {
            Console.WriteLine();
        }
    }
}
