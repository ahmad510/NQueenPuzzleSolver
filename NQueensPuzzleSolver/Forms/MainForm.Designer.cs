namespace NQueensPuzzleSolver.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.btnSolve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSolutions = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchSteps = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numN
            // 
            this.numN.Location = new System.Drawing.Point(16, 29);
            this.numN.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numN.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(120, 20);
            this.numN.TabIndex = 0;
            this.numN.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(142, 26);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSolutions);
            this.groupBox1.Location = new System.Drawing.Point(478, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solutions";
            // 
            // lstSolutions
            // 
            this.lstSolutions.FormattingEnabled = true;
            this.lstSolutions.Location = new System.Drawing.Point(12, 19);
            this.lstSolutions.Name = "lstSolutions";
            this.lstSolutions.Size = new System.Drawing.Size(210, 355);
            this.lstSolutions.TabIndex = 0;
            this.lstSolutions.SelectedIndexChanged += new System.EventHandler(this.lstSolutions_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numN);
            this.groupBox2.Controls.Add(this.btnSolve);
            this.groupBox2.Location = new System.Drawing.Point(478, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearchSteps);
            this.groupBox3.Controls.Add(this.pnlBoard);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 461);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chess Board";
            // 
            // btnSearchSteps
            // 
            this.btnSearchSteps.Location = new System.Drawing.Point(28, 432);
            this.btnSearchSteps.Name = "btnSearchSteps";
            this.btnSearchSteps.Size = new System.Drawing.Size(124, 23);
            this.btnSearchSteps.TabIndex = 0;
            this.btnSearchSteps.Text = "Show Search Steps";
            this.btnSearchSteps.UseVisualStyleBackColor = true;
            this.btnSearchSteps.Click += new System.EventHandler(this.btnShowSearch_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(28, 29);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(400, 400);
            this.pnlBoard.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSolve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N-Queens Puzzle Solver";
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSolutions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnSearchSteps;
    }
}

