﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Base = Convert.ToInt32(textBox1.Text);
            int Power = Convert.ToInt32(textBox2.Text);

            int Value = Convert.ToInt32(Math.Pow(Base, Power));

            textBox3.Text = Value.ToString();


        }
    }
}
