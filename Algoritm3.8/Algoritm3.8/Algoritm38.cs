using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm3._8
{
    public partial class Algoritm38 : Form
    {
        private int sum;
        public Algoritm38()
        {
            InitializeComponent();
        }

        private void btnClic_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            sum = 0;
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            lblResult.Text = sum.ToString();
        }
    }
}
