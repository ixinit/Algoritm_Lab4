using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm3._7
{
    public partial class Algoritm37 : Form
    {
        public Algoritm37()
        {
            InitializeComponent();
        }

        private void btnClic_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            for (int i = 1000; i < 10000; i++)
            {
                if (i % 133 == 125 && i % 134 == 111)
                {
                    lblResult.Text = i.ToString();
                }
            }
        }
    }
}
