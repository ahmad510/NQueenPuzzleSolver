using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NQueensPuzzleSolver.Properties;

namespace NQueensPuzzleSolver.Classes
{
    class Visualizer
    {
        public static void DrawChessBoard(Panel pnlBoard, int boardSize)
        {
            pnlBoard.Height = pnlBoard.Width = 400;
            var squareSize = pnlBoard.Width / boardSize;
            for (var i = 0; i < boardSize; i++)
            {
                for (var j = 0; j < boardSize; j++)
                {
                    pnlBoard.Controls.Add(new PictureBox
                    {
                        BackColor = (i + j) % 2 == 0 ? Color.White : Color.Black,
                        Height = squareSize,
                        Width = squareSize,
                        Top = i * squareSize,
                        Left = j * squareSize,
                        Name = "pic" + i + "," + j
                    });
                }
            }
        }
        public static void DrawState(Panel pnlBoard, IList<int> positions)
        {
            for (var i = 0; i < pnlBoard.Controls.Count; i++)
            {
                var pic = pnlBoard.Controls[i] as PictureBox;
                if (pic != null) pic.BackgroundImage = null;
            }
            for (var i = 0; i < positions.Count; i++)
            {
                var name = "pic" + i + "," + positions[i];
                var pic = pnlBoard.Controls.Find(name, true).FirstOrDefault();
                if (pic == null) continue;
                pic.BackgroundImage = Resources.Queen;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
