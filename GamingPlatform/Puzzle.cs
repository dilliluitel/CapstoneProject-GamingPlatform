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
            //Easy puzzles
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
            {0,0,0,6,0,0,2,0,0},
            {0,2,8,0,4,0,0,0,0},
            {4,5,0,0,0,0,0,8,9},
            {9,0,0,0,6,7,0,0,0},
            {6,3,5,0,1,2,4,0,8},
            {0,8,7,0,3,4,9,6,1},
            {0,0,0,3,9,0,8,0,7},
            {0,0,3,4,0,0,0,2,6},
            {5,0,0,0,8,0,0,0,0}
            },
            new int[,]{
            {0,0,0,2,0,9,0,0,8},
            {2,4,0,0,8,6,0,0,0},
            {0,0,9,0,0,0,0,3,0},
            {0,0,0,0,4,0,5,0,3},
            {3,7,4,5,0,2,8,0,1},
            {0,2,8,6,3,1,9,0,7},
            {9,3,0,1,0,0,0,8,0},
            {0,5,2,0,0,0,0,1,4},
            {0,0,0,0,6,0,0,0,2}
            },

            //Medium puzzles
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
            {6,4,0,0,5,0,0,3,2},
            {0,0,0,0,0,3,0,0,5},
            {3,0,0,0,0,2,1,9,6},
            {1,0,0,0,7,0,0,0,0},
            {0,6,4,0,0,0,0,0,7},
            {7,8,0,0,0,0,0,0,0},
            {0,0,0,0,1,0,0,7,0},
            {0,0,7,0,2,9,0,6,0},
            {0,1,8,0,0,0,4,2,9}
            },
            new int[,]{
            {0,0,0,0,6,0,0,2,0},
            {0,0,0,0,4,3,0,0,0},
            {2,4,5,7,0,0,0,0,0},
            {0,0,0,6,0,0,8,0,0},
            {0,1,9,0,0,4,2,0,0},
            {7,0,0,0,5,8,0,0,0},
            {4,9,0,0,0,6,1,3,0},
            {1,0,6,4,0,7,5,0,0},
            {0,8,0,0,1,0,0,0,4}
            },

            //Hard puzzles
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
            new int[,]{
            {9,0,0,3,1,0,0,0,0},
            {0,8,0,0,0,0,3,0,0},
            {2,0,0,0,0,0,0,0,7},
            {0,6,4,8,0,0,0,0,0},
            {0,0,7,0,0,4,2,0,0},
            {0,0,0,0,0,6,0,0,0},
            {0,0,0,0,0,0,7,4,6},
            {0,0,0,0,5,0,0,8,0},
            {0,0,0,0,8,9,0,2,0}
            },
            new int[,]{
            {8,0,0,0,0,0,0,0,9},
            {0,0,0,0,5,0,0,0,0},
            {0,0,6,4,0,7,2,0,0},
            {0,0,5,0,2,0,0,0,0},
            {0,0,0,0,1,0,3,0,0},
            {6,0,0,3,0,5,0,8,0},
            {0,0,0,1,0,0,0,0,0},
            {0,4,0,0,0,0,0,2,0},
            {0,0,7,6,0,3,4,0,0}
            },
           };

        public int[,] GetPuzzle(int i)
        {
            return puzzle[i];
        }
    }
}
