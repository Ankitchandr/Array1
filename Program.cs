using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    class Program
    {

        public void show(params object[] item)//taking input through params keyword
        {
            for (int i = 0; i < item.Length; i++)
             {
                 Console.WriteLine(item[i]);
             }
          
        }

        static void Main(string[] args)
        {
            int[] A = new int[15] { 3, 4, 1, 4, 7,9,8,7,6,5,4,3,4,5,6 };// single dimention Array
            int[] A1 = new int[8] { 9,9,9,9,9,9,9,9 };// single dimention Array
            char[] B = new char[5] {'A','S','D','E','R' };// single dimention Array
            string[] C = new string[2] {"Ankit","Chandra" };// single dimention Array
            int[,] D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//Double dimention or multiple dimention Array
            char[,] arr = { { 'A', 'B','C' }, { 'D', 'E','F' }, { 'G', 'H', 'I' } };//Double dimention or multiple dimention Array
            int[][] JaggedArray = new int[2][];//JaggedArray
            JaggedArray[0] =new int[]{1,2,3,4 };
            JaggedArray[1] = new int[] {9,8,7,6,6,6,5,4 };
            Array.Copy(A1, A, 3);
            for (int i = 0; i < A.Length; i++)// single dimention Array A print
            {
                Console.WriteLine(A[i]);
            }
            Console.WriteLine(" ");
            for (int i = 0; i < B.Length; i++)// single dimention Array B print
            {
                Console.WriteLine(B[i]);
            }

            Console.WriteLine(" ");

            foreach (int i in A)// single dimention Array A print through foreach loop
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");
            foreach (char i in B)// single dimention Array B print through foreach loop
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" ");
            foreach (string i in C)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 3; i++)//Double dimention or multiple dimention Array D print
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(D[i,j] + " ");
                }
                Console.WriteLine();

            }

            Console.WriteLine(" ");
            for (int i = 0; i < 3; i++)//Double dimention or multiple dimention Array arr print
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();

            }

            Console.WriteLine(" ");
            for (int i = 0; i < 3; i++)//Double dimention or multiple dimention Array arr print
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();

            }


            Console.WriteLine(" ");
            for (int i = 0; i < JaggedArray.Length; i++)//JaggedArray printing
            {
                for (int j = 0; j < JaggedArray[i].Length; j++)
                {
                    Console.Write(JaggedArray[i][j] + " ");
                }
                Console.WriteLine();

            }

            //  Array.Sort(A);
            //Array.Copy(A1,A,3);
            Array.Sort(A, 4, 7);
            for (int i = 0; i < A.Length; i++)// single dimention Array A print after sorting
            {
                Console.WriteLine(A[i]);
            }
            Console.WriteLine(" ");
            Program obj = new Program();
            obj.show(8,7,'a','b','c',"Ankit", "chandra", "kumar");


            int[] InputArray = new int[10];
            Console.WriteLine("Enter 10 element");
            for (int i = 0; i < InputArray.Length; i++)// single dimention InputArray
            {
                InputArray[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" Array Element are...");
            for (int i = 0; i < InputArray.Length; i++)// single dimention InputArray print
            {
                Console.WriteLine(InputArray[i]);
            }


            Console.Read();
            Console.WriteLine();

        }
     

     }
  }

