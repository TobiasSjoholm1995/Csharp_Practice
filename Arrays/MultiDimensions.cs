using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
    class MultiDimensions {
        public MultiDimensions() {
            Console.WriteLine(Environment.NewLine + "Multidimensional: ");
            int[,] twoD = new int[4, 2];    //matrix
            int[][] jagged = new int[4][]   //array of arrays
            {
                new int[] {1, 11 },     //jagged[0]
                new int[] {2, 22 },     //jagged[1]
                new int[] {3, 33 },     //       .
                new int[] {4, 44 }      //       .
            };

            twoD[1, 1] = 3;
            jagged[1][1] = 3;
            Console.WriteLine(twoD[1, 1]);
            Console.WriteLine(jagged[1][1]);

            //different syntax, similar behaviour. 
            //Both can be seen as a 2 dimensional array but jagged array can have diff length on the arrays (rows in the "D table) Which makes it an invalid matrix)

            // stored diff in memory
            // [,] stored in 1 single place, like an array where u multiple the row*column to get the index
            // [][] each array is stored in different place in memory

            mix();

            // Jagged arrays always have rank 1
            Console.WriteLine("Rank jagged: " + jagged.Rank);
            Console.WriteLine("Rank 2D:     " + twoD.Rank);

        }

        void mix() {
            //the 2 versions can be mixed
            int[][,] mixed = new int[4][,] {
                    new int[,] { {1, 2}, {5, 7} },
                    new int[,] { {0, 2}, {4, 3}, {8, 10} },
                    new int[,] { {7, 8}, {5, 1}, {0, 6} },
                    new int[,] { {11, 22}, {99, 88}, {0, 9} }
                };
            Console.WriteLine(mixed[1][1,1]);
        }
    }
}
