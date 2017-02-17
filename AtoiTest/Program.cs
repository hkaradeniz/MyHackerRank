namespace AtoiTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Here is the whole idea behind ATOI.

        //1) You set the pointer at the start of the char array

        //2) And then inside while loop you go over each character and multiply by 10 
        //and add the character by subtracting by 0.

        //And if you will try with 2992. the number would be 2992 as well.

        public int ConvertToInt(string num)
        {
            char[] collection = num.ToCharArray();
            int number = 0;
            int tmp = 0;

            for (int i = 0; i < num.Length; i++)
            {
                tmp = (collection[i] - '0'); // Ascii 0 is 0. 
                number = number * 10 + tmp; //to enlarge the number by *10 every time
            }

            System.Console.WriteLine(">> " + number);
            return number;
        }
    }
}
