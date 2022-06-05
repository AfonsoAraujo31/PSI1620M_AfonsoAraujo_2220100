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
        string nome;
        public Reset_password(string value)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            nome = Convert.ToString(value);
        }
        public void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox_password.Text)
            {
                try
                {
                    string query = "UPDATE login_utilizadores SET password = '" + this.textBox_password.Text + "' WHERE username = @user ";
                    SqlConnection sqlCon = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@user", nome);
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
