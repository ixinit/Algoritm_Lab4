using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm3._1
{
    public partial class Algoritm31 : Form
    {
        private int num;
        private String nums;
        public Algoritm31()
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
            if (num == 0)
            {
                MessageBox.Show("Деление на нуль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnClic_Click(object sender, EventArgs e)
        {
            if (inputCheckExeption()) {
                lblResult.Text = "";
                nums = "";
                for (int i = 10; i < 100; i++)
                {
                    if (i % 10 == num || i / 10 == num || i % num == 0)
                    {
                        nums += i + " ";
                    }
                }
                lblResult.Text = nums;
            }
        }
    }
}
