using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum4_Task2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void rec(int i)
        {
            if (i == 0)
                return;
            else
                richTextBox1.Text += $"{i} ";
                rec(i - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n;
            n = (int)numericUpDown1.Value;

            if(n < 1000)
            {
                MessageBox.Show("Число должно быть больше 1000!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            richTextBox1.Clear();
            rec(n);
        }
    }
}
