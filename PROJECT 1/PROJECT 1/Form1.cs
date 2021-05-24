using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            label1.AutoSize = true;
            button1.Text = "HI";
            button1.ForeColor = Color.Magenta;
            label1.BorderStyle = BorderStyle.Fixed3D;
            
        }
    }
}
