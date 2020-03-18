using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm3._28
{
    public partial class Algoritm328 : Form
    {
        public Algoritm328()
        {
            InitializeComponent();
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "C";
            column1.Name = "cel";
            column1.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(column1);

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "F";
            column2.Name = "fahr";
            column2.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(column2);
        }

        private void echoGrid()
        {
            for (int i=0; i<101; i++)
            {
                dataGridView1.Rows.Add(i, getFehr(i));
                //dataGridView1["cel", dataGridView1.Rows.Count - 1].Value = i;
            }
        }

        private string getFehr(int cel)
        {
            return (9 * Convert.ToDouble(cel) / 5 + 32).ToString("#.##");
        }

        private void btnClic_Click(object sender, EventArgs e)
        {
            echoGrid();
        }
    }
}
