using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zivver.Candidate.Assignment.UI.Controls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            this.AutoSize = true;
            this.textBox1.Text = "Welcome to the ZIVVER Assignment for C# developers!";
            var strSize = this.CreateGraphics().MeasureString("Welcome to the ZIVVER Assignment for C# developers!", this.textBox1.Font);
            this.textBox1.Width = (int)(Math.Round(strSize.Width, 0));
            this.pictureBox1.Dock = DockStyle.Right;
        }
    }
}
