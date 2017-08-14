using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // string dt = dateTimePicker1.Value.ToShortDateString();
           // label1.Text = dt;
            label1.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
