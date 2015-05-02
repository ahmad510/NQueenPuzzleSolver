using System.Collections.Generic;
using System.Windows.Forms;
using NQueensPuzzleSolver.Classes;

namespace NQueensPuzzleSolver.Forms
{
    public partial class MainForm : Form
    {
        private List<State> _states = new List<State>();
        public MainForm()
        {
            InitializeComponent();
            var boardSize = (int)numN.Value;
            Visualizer.DrawChessBoard(pnlBoard, boardSize);
        }
        private void ClearForm()
        {
            _states.Clear();
            lstSolutions.Items.Clear();
            pnlBoard.Controls.Clear();
        }
        private void btnSolve_Click(object sender, System.EventArgs e)
        {
            btnSolve.Enabled = false;
            ClearForm();
            var boardSize = (int)numN.Value;
            _states = Solver.GetSolutions(boardSize);
            for (var i = 1; i <= _states.Count; i++) lstSolutions.Items.Add("Solution " + i);
            Visualizer.DrawChessBoard(pnlBoard, boardSize);
            btnSolve.Enabled = true;
        }
        private void lstSolutions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Visualizer.DrawState(pnlBoard, _states[lstSolutions.SelectedIndex].PositionsOfQueens);
        }
        private void btnShowSearch_Click(object sender, System.EventArgs e)
        {
            btnSearchSteps.Enabled = false;
            ClearForm();
            var boardSize = (int)numN.Value;
            _states = Solver.GetSearchSteps(boardSize);
            lstSolutions.Items.Add("Step 1 (Initial State)");
            for (var i = 2; i <= _states.Count; i++)
            {
                if (_states[i - 1].IsGoalState)
                    lstSolutions.Items.Add("Step " + i + " (Goal State)");
                else
                    lstSolutions.Items.Add("Step " + i);
            }
            Visualizer.DrawChessBoard(pnlBoard, boardSize);
            btnSearchSteps.Enabled = true;
        }
    }
}
