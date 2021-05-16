using System;

namespace ExceptionTestLab
{
    public static class TestTasks
    {
        public static void InvalidCastExceptionTest()
        {
            try
            {
                bool flag = true;
                Char ch = Convert.ToChar(flag);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ArraysExceptionTest(int numOfElements)
        {
            decimal[] array1 = new decimal[5] { 1, 2, 3, 4, 5 };
            decimal[] array2 = new decimal[7] { 9, 8, 7, 6, 5, 6, 7 };

            try
            {
                decimal[] arrayResult = new decimal[numOfElements];
                for (int i = 0; i < numOfElements; i++)
                {
                    arrayResult[i] = array1[i] / array2[i];
                }
            }
            catch (IndexOutOfRangeException ex) when(array1.Length < array2.Length)
            {
                Console.WriteLine(ex);
                Console.WriteLine("array1 has less elements than array2");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}