using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineSparseMatrix
{
    // Program to determine whether a given matrix is sparse or dense

    // A sparse matrix is a matrix in which most of the elements are zero. 
    // By contrast, if most of the elements are nonzero, then the matrix 
    // is considered as dense matrix.
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[10, 10];
            int i, j, r, c;
            int ctr = 0;

            Console.Write("\n\nDetermine whether a matrix is a sparse matrix : \n");
            Console.Write("----------------------------------------------------\n");
            Console.Write("Input the number of rows of the matrix : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns of the matrix : ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input elements in the first matrix : \n");
            for(i = 0; i < r; i++)
            {
                for(j = 0; j < c; j++)
                {
                    Console.Write("element - [{0}], [{1}] :", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if(arr1[i, j] == 0)
                    {
                        ++ctr;
                    }
                }
            }            
            if(ctr > ((r * c) / 2))
            {
                Console.Write("The given matrix is sparse martrix. \n");
            }
            else
            {
                Console.Write("The given matrix is not a sparse matrix. \n");
            }
            
        }
    }
}
