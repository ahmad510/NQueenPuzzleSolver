using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueensPuzzleSolver.Classes
{
    class State
    {
        public bool IsGoalState { get; set; }
        public int[] PositionsOfQueens { get; set; }
    }
}
