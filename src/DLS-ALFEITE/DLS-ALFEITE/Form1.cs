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
        public Frm_login()
        {
            InitializeComponent();
        }
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Insira o username ou password");
            }
            else
            {
                try
                {
                    SqlConnection sql = new SqlConnection(connection);
                    SqlCommand cmd = sql.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"select username,password from login_utilizadores where username=@Username and password=@Userpass";
                    cmd.Parameters.AddWithValue("@Username", textBox_username.Text);
                    cmd.Parameters.AddWithValue("@Userpass", textBox_password.Text);

                    sql.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    sql.Close();

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Bem Boneco");
                    }
                    else
                    {
                        MessageBox.Show("És mesmo da  Digital");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:{0}", ex.Message);
                }
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


