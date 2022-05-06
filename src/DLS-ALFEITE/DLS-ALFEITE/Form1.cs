using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DLS_ALFEITE
{
    public partial class Frm_login : Form
    {
        private string ContionString;
        public Frm_login()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Insira o username ou password");
                return;
            }
            try
            {
                SqlConnection sqlConn = new SqlConnection(ContionString);
                SqlCommand cmd = sqlConn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT username,password FROM login_utilizadores WHERE username='" + textBox_username.Text + "' AND password='" + textBox_password.Text + "'";
                sqlConn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("asas");
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:{0}",ex.Message);
            }
        }

        private void textBox_password_Enter_1(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Password")
            {
                textBox_password.Text = "";
                textBox_password.PasswordChar = '●';
            }
        }
        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text == "")
            {
                textBox_password.Text = "Password";
                textBox_password.PasswordChar = '\0';
            }
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox_password.PasswordChar == '●')
            {
                button1.BringToFront();
                textBox_password.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_password.PasswordChar == '\0')
            {
                button2.BringToFront();
                textBox_password.PasswordChar = '●';
            }
        }

        

        private void textBox_username_Enter_1(object sender, EventArgs e)
        {
            if (textBox_username.Text == "Username")
            {
                textBox_username.Text = "";
            }
        }

        private void textBox_username_Leave(object sender, EventArgs e)
        {

        }
    }
}


