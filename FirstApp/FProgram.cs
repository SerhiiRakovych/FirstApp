using System;
using System.Diagnostics;
using MyLib;

namespace FirstApp
{
    class FProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIRST APP OUT");
            Console.WriteLine($"Method Add result: {SimpleMath.Add(100, 500)}");
            Console.WriteLine($"Method Subst result: {SimpleMath.Subst(100, 500)}");
            Console.WriteLine($"Method Subst result: {SimpleMath.Subst(100, 20)}");
            Console.WriteLine($"Method Devide result: {SimpleMath.Devide(500, 100)}");
            Console.WriteLine($"Method Mult result: {SimpleMath.Mult(100, 500)}");

            Console.WriteLine("------------------------------------------------------");

            object mvar = 6;
            Console.WriteLine($"mvar is {mvar??100}");

            Client cl = new Client();

            Console.ReadKey();


            #region OldCode
            //int param = 100;
            //int outpr;

            //Console.WriteLine(Marsohod(ref param, out int pr).ToString());

            //  Marsohod(ref param, out outpr);
            //  Console.WriteLine(outpr);


            // Console.WriteLine(param);

            //void Marsohod(ref int param, out int outpr)
            //{
            //    param += 100500;

            //    outpr = 3456789-param;
            //    Debug.Write("SSSSSSSSSSSSSSSSSSSSSSSSSSS");
            //    Debug.Assert(true, "SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
            //}


            //static void MSort()
            //{
            //    const int arrSize = 5;
            //    int[] arr = new int[arrSize];
            //    int temp = 0;

            //    //-----Ввод массива------

            //    for (int i = 0; i < arrSize; i++)
            //    {
            //        Console.Write($"Введите {i + 1}-ое число: ");
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("-----------------------------------");

            //    //-----Отображение исходного массива------
            //    Console.WriteLine("Исходный массив:");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //    Console.WriteLine("-----------------------------------");

            //    //-----Сортировка массива------
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] > arr[j])
            //            {
            //                temp = arr[i];
            //                arr[i] = arr[j];
            //                arr[j] = temp;
            //            }
            //        }
            //    }

            //    //-----Отображение отсортированного массива------
            //    Console.WriteLine("Отсортированный массив:");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //    Console.WriteLine("-----------------------------------");
            //}
            #endregion
        }
    }
}
