﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_games_store
{
    public partial class Form2 : Form
    {
       
        public string Login { get; set; }
        public string Password { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPas_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "admin" && textBoxPas.Text == "QweRt098")
            {
                Login = textBoxLog.Text;
                Password = textBoxPas.Text;
                this.Close();
            }
            else
                MessageBox.Show("Неверный логин или пароль!");
        }
    }
}
