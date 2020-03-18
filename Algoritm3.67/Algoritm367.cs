using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm3._67
{
    public partial class Algoritm367 : Form
    {
        public Algoritm367()
        {
            InitializeComponent();
        }

        private int getResult(int num)
        {
            return num * num + num + 17;
        }

        private string isSimple(int num)
        {
            if (num > 1)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return "число не является простым";
                    }
                }
                return "число является простым";
            }
            else
            {
                return "Ошибка";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string tbl="";
            lblResult.Text = "";
            for (int i = 0; i<16; i++)
            {
                tbl += "x="+i+" "+getResult(i)+" "+isSimple(getResult(i))+"\n";
            }
            lblResult.Text = tbl;
        }
    }
}
