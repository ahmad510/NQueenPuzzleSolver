using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueensPuzzleSolver.Classes
{
    class Solver
    {
        public static List<State> GetSolutions(int size)
        {
            var solutions = new List<State>();
            var row = 0;
            var positions = Enumerable.Repeat(-1, size).ToArray();                                             // set initial state (all positions are -1) no queen on board
            while (true)
            {
                int suggestedPosition;                                                                         // suggested position within a row
                for (suggestedPosition = positions[row] + 1; suggestedPosition < size; suggestedPosition++)    // loop until the position is attacked, or all board scanned and the suggestedPosition is safe
                {
                    int i;
                    for (i = 0; i < row; i++)
                    {
                        var dis = row - i;
                        if (positions[i] == suggestedPosition || positions[i] == suggestedPosition + dis || positions[i] == suggestedPosition - dis) break;
                    }
                    if (i != row) continue;                                                                    // IF (i != row) THEN the loop finished before completing board scan (attack found), so start again, suggest new position ELSE accept the suggestedPosition
                    positions[row] = suggestedPosition;                                                        // set the new position
                    row++;                                                                                     // move to rowIndex to the next row
                    if (row != size) break;                                                                    // IF (row != size) THEN there're more rows to be seen, get out of this loop and start the outer loop on the new row ELSE a solution is found
                    solutions.Add(new State {PositionsOfQueens = positions.ToArray()});                        // add the solution to the solutions list
                    row--;                                                                                     // continue working on this row, we don't need to move to the next yet
                }
                if (suggestedPosition != size) continue;                                                       // if true then there're more positions to be suggested on this row
                if (row == 0) break;                                                                           // if row == 0 then the search is complete
                positions[row] = -1;                                                                           // last suggestedPosition reached and queen should be removed from the board
                row--;                                                                                         // Backtracking; move to the previous row to change its (previously accepted) position
            }
            return solutions;
        }

        public static List<State> GetSearchSteps(int size)
        {
            var steps = new List<State>();
            var row = 0;
            var positions = Enumerable.Repeat(-1, size).ToArray();
            steps.Add(new State {PositionsOfQueens = positions.ToArray()});
            while (true)
            {
                int suggestedPosition;
                for (suggestedPosition = positions[row] + 1; suggestedPosition < size; suggestedPosition++)
                {
                    int i;
                    for (i = 0; i < row; i++)
                    {
                        var dis = row - i;

                        if (positions[i] != suggestedPosition && positions[i] != suggestedPosition + dis &&
                            positions[i] != suggestedPosition - dis) continue;
                        var m = positions.ToArray();
                        m[row] = suggestedPosition;
                        steps.Add(new State {PositionsOfQueens = m});
                        break;
                    }
                    if (i != row) continue;
                    positions[row] = suggestedPosition;
                    var state = new State {PositionsOfQueens = positions.ToArray()};
                    steps.Add(state);
                    row++;
                    if (row != size) break;
                    state.IsGoalState = true;
                    row--;
                }
                if (suggestedPosition != size) continue;
                if (row == 0) break;
                positions[row] = -1;
                steps.Add(new State { PositionsOfQueens = positions.ToArray() });
                row--;
            }
            return steps;
        }
    }
}
