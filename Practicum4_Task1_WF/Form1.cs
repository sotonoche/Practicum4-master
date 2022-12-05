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

        static int f(int n, int m)
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
            int n, m, res;

            n = (int)numericUpDownN.Value;
            m = (int)numericUpDownM.Value;

            if(n < 0 || m < 0)
            {
                MessageBox.Show("Введенные значения должны быть неотрицательными!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n > 3 && m > 0)
            {
                MessageBox.Show("Значение n не может быть больше 3, иначе стек будет переполнен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n > 3 && m > 11)
            {
                MessageBox.Show("Значение n не может быть больше 3, а значение m не может быть больше 11, т.к. стек будет переполнен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            res = f(n, m);
            textBoxRes.Text = $"{res}";
        }
    }
}
