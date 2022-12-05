using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum4_Task1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double n, double m)
        {
            if (n == 0)
                return m + 1;
            else
            if ((n != 0) && (m == 0))
                return f(n - 1, 1);
            else
                return f(n - 1, f(n, m - 1));
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            double n, m, res;

            n = (double)numericUpDownN.Value;
            m = (double)numericUpDownM.Value;

            if(n < 0 || m < 0)
            {
                MessageBox.Show("Введенные значения должны быть неотрицательными!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            res = f(n, m);
            textBoxRes.Text = $"{res}";
        }
    }
}
