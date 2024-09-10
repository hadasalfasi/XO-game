using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xo
{
    internal class board
    {

        //public char[,] mat { get; set; }
        public char[,] mat = new char[3, 3];

        // Printing the board
        public void Print()
        {
            for (int i = 0; i < this.mat.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < this.mat.GetLength(1); j++)
                {
                    Console.Write(this.mat[i, j] +"   |  ");
                }
                Console.WriteLine();
                Console.WriteLine("----------------");
            }
        }

        // Checking if the position is empty

        public bool Isnull(int i, int j)
        {
            if (this.mat[i, j] != 'x'&& this.mat[i, j]!='o')
                return true;
            return false;
        }

        // Inserting the value into the appropriate position
        public void insert(int i, int j, char c)
        {
            this.mat[i, j] = c;
        }

        // Checking for a winner
        public bool Iswin(char c)
        {
            int c1 = 0;
            int i = 0,j=0;
            for ( i = 0; i < 3; i++)
            {
                for ( j = 0; j < 3; j++)
                {
                    if (this.mat[i, j] ==(char)c)
                        c1++;                    
                }                                            
            }
            if (c1 < 3)
                return false;
            c1 = 0;
            if (mat[1, 1] == c)
            { 
               if ((mat[1, 1] == mat[0, 0] && mat[1, 1] == mat[2, 2])|| (mat[1, 1] == mat[0, 2] && mat[1, 1] == mat[2, 0]))
                return true;
            }
            c1 = 0;
             i = 0;
            while (c1 < 3&&i<3)
            {
                c1 = 0;
                for ( j = 0; j < 3; j++)
                    {
                        if (this.mat[i, j] == c)
                            c1++;
                    }
                 i++;
            }
            if (c1 == 3)
                return true;
            c1 = 0;
            i = 0;
            j = 0;
            while (c1 < 3 && j < 3)
            {
                c1 = 0;
                for ( i = 0; i< 3; i++)
                {
                    if (this.mat[i, j] == c)
                        c1++;
                }
                j++;
            }
            if (c1 == 3)
                return true;
            return false;
        }









    }
}
