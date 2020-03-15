using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm3._3
{
    public partial class Algoritm33 : Form
    {
        private int num;
        private int nums;
        public Algoritm33()
        {
            InitializeComponent();
        }
        private bool inputCheckExeption()
        {
            try
            {
                num = Convert.ToInt32(tbNum.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnClic_Click(object sender, EventArgs e)
        {
            if (inputCheckExeption())
            {
                lblResult.Text = "";
                nums = 0;
                for (int i = 100; i < 1000; i++)
                {
                    if ((i / 100) + (i / 10 % 10) + (i % 10) == num)
                    {
                        nums += 1;
                    }
                }
                lblResult.Text = nums.ToString();
            }
        }
    }
}
