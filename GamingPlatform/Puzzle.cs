using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingPlatform
{
   public class Puzzle
    {

        int[][,] puzzle = {
            new int[,]{
            {7,0,2,0,5,0,6,0,0},
            {0,0,0,0,0,3,0,0,0},
            {1,0,0,0,0,9,5,0,0},
            {8,0,0,0,0,0,0,9,0},
            {0,4,3,0,0,0,7,5,0},
            {0,9,0,0,0,0,0,0,8},
            {0,0,9,7,0,0,0,0,5},
            {0,0,0,2,0,0,0,0,0},
            {0,0,7,0,4,0,2,0,3}
            },
            new int[,]{
            {5,0,0,0,0,0,0,0,0},
            {3,4,0,1,0,0,0,0,7},
            {0,9,0,0,0,6,0,0,0},
            {6,0,0,0,2,0,0,0,9},
            {0,0,4,9,8,0,1,0,0},
            {0,1,0,0,4,0,0,0,0},
            {0,0,0,0,0,3,0,2,6},
            {0,0,0,0,0,0,8,0,0},
            {9,0,0,0,0,0,3,4,0}
            },
            new int[,]{
            {0,0,0,0,0,6,0,0,5},
            {0,0,9,0,5,8,0,0,0},
            {0,0,1,0,0,0,9,2,0},
            {0,0,0,0,0,0,2,0,0},
            {7,4,0,0,0,0,3,0,0},
            {0,3,0,0,0,0,0,0,7},
            {9,0,0,0,1,3,0,7,0},
            {2,5,0,0,9,0,8,0,0},
            {0,0,0,0,0,0,0,4,0}
            },
           };

        public int[,] GetPuzzle(int i)
        {
         /* var grid = new int[3][,]();          
            Array.Copy(puzzle, grid, puzzle.Length);
            
           puzzle.CopyTo(grid);
           int[][,] grid1 = (int[][,])puzzle.CopyTo();
           grid = grid1[i]; */

            return puzzle[i];
        }

    }
}
