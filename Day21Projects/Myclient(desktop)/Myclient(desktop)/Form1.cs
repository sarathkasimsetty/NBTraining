using Myclient_desktop_.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sarath kasimsetty

namespace Myclient_desktop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            AlgebraSoapClient m = new AlgebraSoapClient();

            textBox2.Text = m.Factorial(n).ToString();
            Console.ReadLine();
        }
    }
}
