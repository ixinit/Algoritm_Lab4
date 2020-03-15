using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm3._13
{
    public partial class Algoritm313 : Form
    {
        private int num;
        public Algoritm313()
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
            if (num < 0)
            {
                MessageBox.Show("При таком параметре будет дробь. (Программа работает только с натуралными числами и нулем)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnClic_Click(object sender, EventArgs e)
        {
            if (inputCheckExeption())
            {
                int nums;
                lblResult.Text = "";
                //проще циклом
                //lblResult.Text = (Math.Pow(7, Convert.ToDouble(num)) % 10).ToString();

                nums = 1;
                for (int i = 0; i < num; i++)
                {
                    // 17 = (10+7)
                    nums *= 7;
                }
                lblResult.Text = (nums % 10).ToString();
            }
        }
    }
}
