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
        }
        private void btn_login_codigounico_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connection);
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT username,codigo_unico FROM login_utilizadores WHERE username=@user AND codigo_unico=@cd_unico";
            cmd.Parameters.AddWithValue("@user", txb_username.Text);
            cmd.Parameters.AddWithValue("@cd_unico", textBox_codigo_unico.Text);
            sqlcon.Open();
            SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqladp.Fill(ds);
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

        private void button5_Click_1(object sender, EventArgs e)
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
                    sqlCon.Close();
                    Frm_login fr = new Frm_login();
                    fr.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
    