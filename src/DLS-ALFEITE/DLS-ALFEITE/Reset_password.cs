using System;
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
    public partial class Reset_password : Form
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
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        public Reset_password()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.ActiveControl = txb_username;
        }
        private void btn_login_codigounico_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connection);
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT username,codigo_unico FROM login_utilizadores WHERE username=@user AND codigo_unico=@cd_unico";
            cmd.Parameters.AddWithValue("@user", txb_username.Text);
            cmd.Parameters.AddWithValue("@cd_unico", txb_codigo_unico.Text);
            sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            sqlcon.Close();
            int count1 = ds.Tables[0].Rows.Count;
            if (count1 == 1)
            {
                label4.Text = txb_username.Text;
                panel1.SendToBack();
                panel6.BringToFront();
            }
            else
            {
                MessageBox.Show("Username ou código único errados!");
            }
        }
        private void btn_login_reset_Click(object sender, EventArgs e)
        {
            if (txb_nova_password.Text == txb_comfirmacao_password.Text)
            {
                try
                {
                    string query = "UPDATE login_utilizadores SET password = '" + this.txb_comfirmacao_password.Text + "' WHERE username = @user ";
                    SqlConnection sqlCon = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@user", txb_username.Text);
                    SqlDataReader myreader;
                    sqlCon.Open();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {
                        MessageBox.Show("Saved");
                    }
                    this.Close();
                    Frm_login fr = new Frm_login();
                    sqlCon.Close();
                    fr.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void txb_username_Enter(object sender, EventArgs e)
        {
            if (txb_username.Text == "Username")
            {
                txb_username.Text = "";
            }
        }

        private void txb_username_Leave(object sender, EventArgs e)
        {
            if (txb_username.Text == "")
            {
                txb_username.Text = "Username";
            }
        }

        private void textBox_codigo_unico_Enter(object sender, EventArgs e)
        {
            if (txb_codigo_unico.Text == "Código Único")
            {
                txb_codigo_unico.Text = "";
                txb_codigo_unico.PasswordChar = '●';
            }
        }

        private void txb_codigo_unico_Leave(object sender, EventArgs e)
        {
            if (txb_codigo_unico.Text == "")
            {
                txb_codigo_unico.Text = "Código Único";
                txb_codigo_unico.PasswordChar = '\0';
            }
        }

        private void btn__Click(object sender, EventArgs e)
        {
            if (txb_codigo_unico.PasswordChar == '●')
            {
                btn_2.BringToFront();
                txb_codigo_unico.PasswordChar = '\0';
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txb_codigo_unico.PasswordChar == '\0')
            {
                btn_.BringToFront();
                txb_codigo_unico.PasswordChar = '●';
            }
        }

        private void txb_nova_password_Enter(object sender, EventArgs e)
        {
            if (txb_nova_password.Text == "Nova Password")
            {
                txb_nova_password.Text = "";
            }
        }

        private void txb_nova_password_Leave(object sender, EventArgs e)
        {
            if (txb_nova_password.Text == "")
            {
                txb_nova_password.Text = "Nova Password";
            }
        }

        private void txb_comfirmacao_password_Enter(object sender, EventArgs e)
        {
            if (txb_comfirmacao_password.Text == "Confirmar Password")
            {
                txb_comfirmacao_password.Text = "";
            }
        }

        private void txb_comfirmacao_password_Leave(object sender, EventArgs e)
        {
            if (txb_comfirmacao_password.Text == "")
            {
                txb_comfirmacao_password.Text = "Confirmar Password";
            }
        }
    }
}
    