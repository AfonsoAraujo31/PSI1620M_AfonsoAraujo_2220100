﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;


namespace DLS_ALFEITE
{
    public partial class Frm_login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
             int nleftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nwidthEllipse,
             int nHeightEllipse
        );
        bool check = false;
        public Frm_login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "AdminAA22" && textBox_password.Text == "AdminAA22")
            {
                check = true;
                new panel_mdi(textBox_username.Text, check).Show();
                this.Hide();
            }
            else
            {
                check = false;
                try
                {
                    if (textBox_username.Text == "" && textBox_password.Text == "")
                    {
                        MessageBox.Show("Preencha os campos");
                    }
                    else
                    {
                        SqlConnection sqlcon = new SqlConnection(connection);
                        SqlCommand cmd = sqlcon.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = $"SELECT username,password FROM Utilizadores WHERE username=@Username AND password=@Userpass";
                        cmd.Parameters.AddWithValue("@Username", textBox_username.Text);
                        Program.value = textBox_username.Text;
                        cmd.Parameters.AddWithValue("@Userpass", textBox_password.Text);
                        sqlcon.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        int count = ds.Tables[0].Rows.Count;
                        if (count == 1)
                        {
                            new panel_mdi(textBox_username.Text, check).Show();
                            this.Hide();
                            sqlcon.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username ou password incorretos!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            if (textBox_username.Text == "")
            {
                textBox_username.Text = "Username";
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox_username.Text == "AdminAA22" && textBox_password.Text == "AdminAA22")
                {
                    check = true;
                    new panel_mdi(textBox_username.Text,check).Show();
                    this.Hide();
                }
                else
                {
                    check = false;
                    try
                    {
                        if (textBox_username.Text == "" && textBox_password.Text == "")
                        {
                            MessageBox.Show("Preencha os campos");
                        }
                        else
                        {
                            SqlConnection sqlcon = new SqlConnection(connection);
                            SqlCommand cmd = sqlcon.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = $"SELECT username,password FROM Utilizadores WHERE username=@Username AND password=@Userpass";
                            cmd.Parameters.AddWithValue("@Username", textBox_username.Text);
                            Program.value = textBox_username.Text;
                            cmd.Parameters.AddWithValue("@Userpass", textBox_password.Text);
                            sqlcon.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            int count = ds.Tables[0].Rows.Count;
                            if (count == 1)
                            {
                                new panel_mdi(textBox_username.Text,check).Show();
                                this.Hide();
                                sqlcon.Close();
                            }
                            else
                            {
                                MessageBox.Show("Username ou password incorretos!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Opacity = 0.80;
            Reset_password reset_Password = new Reset_password();
            reset_Password.Show();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


