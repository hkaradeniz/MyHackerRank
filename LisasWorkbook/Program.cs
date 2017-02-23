using System;

namespace LisasWorkbook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);

            string[] a_integers = Console.ReadLine().Split(' ');
            Int32[] t = Array.ConvertAll(a_integers, Int32.Parse);

            int questionNum = 1;
            int pageNum = 1;
            int specialQuestions = 0;

            for (int i = 0; i < n; i++)
            {
                int totalQuestionsInSection = t[i];
                while (questionNum <= totalQuestionsInSection)
                {
                    if (questionNum == pageNum)
                    {
                        specialQuestions++;
                    }

                    if (questionNum % k == 0 || questionNum == totalQuestionsInSection)
                    {
                        pageNum++;
                    }

                    questionNum++;
                }

                questionNum = 1;
            }

            Console.WriteLine(specialQuestions);
        }
    }
}
