using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                MyTree myTree = new MyTree();

                for (int j = 1; j <= n; j++)
                {
                    if (j % 2 == 1)
                        myTree.GrowSpring();
                    else
                        myTree.GrowSummer();
                }

                Console.WriteLine(myTree.GetTreeHeight());
            }
        }
    }
}
