namespace RockPaperScissors_ML
{
    partial class formGame
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnRock = new PictureBox();
            btnPaper = new PictureBox();
            btnScissors = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            AIpick = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnScissors).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AIpick).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.imgFondo;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(81, 59);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(621, 442);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnRock, 0, 0);
            tableLayoutPanel3.Controls.Add(btnPaper, 1, 0);
            tableLayoutPanel3.Controls.Add(btnScissors, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 113);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(428, 215);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnRock
            // 
            btnRock.Anchor = AnchorStyles.None;
            btnRock.Cursor = Cursors.Hand;
            btnRock.Image = Properties.Resources.btnRock;
            btnRock.Location = new Point(3, 40);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(136, 135);
            btnRock.SizeMode = PictureBoxSizeMode.Zoom;
            btnRock.TabIndex = 0;
            btnRock.TabStop = false;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Anchor = AnchorStyles.None;
            btnPaper.Cursor = Cursors.Hand;
            btnPaper.Image = Properties.Resources.btnPaper;
            btnPaper.Location = new Point(145, 41);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(136, 133);
            btnPaper.SizeMode = PictureBoxSizeMode.Zoom;
            btnPaper.TabIndex = 1;
            btnPaper.TabStop = false;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissors
            // 
            btnScissors.Anchor = AnchorStyles.None;
            btnScissors.Cursor = Cursors.Hand;
            btnScissors.Image = Properties.Resources.btnScissors;
            btnScissors.Location = new Point(287, 41);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(138, 133);
            btnScissors.SizeMode = PictureBoxSizeMode.Zoom;
            btnScissors.TabIndex = 2;
            btnScissors.TabStop = false;
            btnScissors.Click += btnScissors_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 334);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(428, 105);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.btnReturn;
            pictureBox1.Location = new Point(48, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.btnStats;
            pictureBox2.Location = new Point(259, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(AIpick, 0, 1);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(437, 113);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel5.Size = new Size(181, 215);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // AIpick
            // 
            AIpick.Anchor = AnchorStyles.None;
            AIpick.Image = Properties.Resources.btnScissors;
            AIpick.Location = new Point(21, 73);
            AIpick.Name = "AIpick";
            AIpick.Size = new Size(138, 133);
            AIpick.SizeMode = PictureBoxSizeMode.Zoom;
            AIpick.TabIndex = 3;
            AIpick.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 21);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 4;
            label1.Text = "AI's pick";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(502, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 3;
            label2.Text = "score";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 44);
            label3.Name = "label3";
            label3.Size = new Size(231, 21);
            label3.TabIndex = 4;
            label3.Text = "Select rock, paper or scissors:";
            // 
            // formGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "formGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock Paper Scissors";
            Resize += formGame_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnScissors).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AIpick).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox btnRock;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnPaper;
        private PictureBox btnScissors;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox AIpick;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}