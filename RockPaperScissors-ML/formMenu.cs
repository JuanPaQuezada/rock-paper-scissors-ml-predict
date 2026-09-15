using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace RockPaperScissors_ML
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(640, 480);

        }

        private void formMenu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.SuspendLayout();
                int targetWidth = (this.Height * 4) / 3;

                if (this.Width != targetWidth)
                {
                    this.Width = targetWidth;
                }

                this.ResumeLayout();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formGame formGame = new formGame();
            formGame.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
