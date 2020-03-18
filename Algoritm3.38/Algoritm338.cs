using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm3._38
{
    public partial class Algoritm338 : Form
    {
        public Algoritm338()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string tabl="";
            for (int i = 0; i<10; i++)
            {
                tabl += "7*" + i + "=" + (7 * i)+"   ";
            }
            lblResult.Text = tabl;
        }
    }
}
