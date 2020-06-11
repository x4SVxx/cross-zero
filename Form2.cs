using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "";

            this.Width = 300;
            this.Height = 100;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.CenterToScreen(); ;

            label1.Location = new Point((this.Width - label1.Width) / 2, (this.Height - label1.Height) / 2);

            button1.Size = new Size(25, 25);
            button1.Location = new Point(this.Width - 25 - 7, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
