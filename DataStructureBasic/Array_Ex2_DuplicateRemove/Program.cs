using System;

namespace Array_Ex2_DuplicateRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nums = ");
            string inputitems = Console.ReadLine();

            char[] seperator = new char[] { ',', '[', ']' };
          
            string[] inputStringArray = inputitems.Split(seperator);

            int[] inputIntArrays = RemoveDuplicates(inputStringArray);
            string result = "[";
            for (int i = 0; i < inputIntArrays.Length; i++)
            {
                if (inputIntArrays.Length > 0)
                {
                    result += inputIntArrays[i];
                    if (i != inputIntArrays.Length-1)
                        result += ",";
                }
            }
            result += "]";
            Console.WriteLine($"{inputIntArrays.Length}, nums = {result}");
            Console.ReadKey();
        }

        public static int[] RemoveDuplicates(string[] numbers)
        {
            int[] temparray = { };
            for (int i = 0; i < numbers.Length; i++)
            {
                int inputnumber = 0;
                if (int.TryParse(numbers[i], out inputnumber))
                {
                    if (temparray.Length != 0)
                    {
                        if (!Array.Exists(temparray, z => z == inputnumber))
                        {
                            Array.Resize(ref temparray, temparray.Length + 1);
                            temparray[temparray.Length - 1] = inputnumber;
                        }
                    }
                    else
                    {
                        temparray = new int[] { Convert.ToInt32(numbers[i]) };
                    }
                }
            }
            return temparray;
        }
    }
}
