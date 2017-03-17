using System;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                int grade = Convert.ToInt32(Console.ReadLine());

                int temp = grade + 2;
                int remain = temp % 5;

                if (remain < 3 && temp > 39)
                {
                    Console.WriteLine(temp - remain);
                }
                else
                {
                    Console.WriteLine(grade);
                }
            }
        }
    }
}
