﻿using DBProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject.View
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var DB = new Controller.MainContext();
            DB.Add(new Customer( textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
            DB.SaveChanges();
        }
    }
}
