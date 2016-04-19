using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinISP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logic.Class2 cls2 = new Logic.Class2("Заголовок был такой:\n", this.button1.Text);
            MessageBox.Show(cls2.getSumStr());

            Logic.Class1 cls1 = new Logic.Class1(10, 20);
            this.button1.Text = cls1.getSumm().ToString();
        }
    }
}
