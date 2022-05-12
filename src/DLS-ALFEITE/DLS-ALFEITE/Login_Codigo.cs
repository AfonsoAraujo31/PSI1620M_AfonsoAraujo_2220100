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
    public partial class Login_Codigo : Form
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
        public Login_Codigo(string value)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            textBox_username_confirmação.Enabled = false;
            textBox_username_confirmação.Text = value;
        }
        private string value { get; set; }
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        private void textBox_codigo_unico_Enter(object sender, EventArgs e)
        {
            if (textBox_codigo_unico.Text == "Código Único")
            {
                textBox_codigo_unico.Text = "";
                textBox_codigo_unico.PasswordChar = '●';
            }
        }

        private void textBox_codigo_unico_Leave(object sender, EventArgs e)
        {
            if (textBox_codigo_unico.Text == "")
            {
                textBox_codigo_unico.Text = "Código Único";
                textBox_codigo_unico.PasswordChar = '\0';
            }
        }
        
        private void btn_login_codigounico_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connection);
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT codigo_utilizador FROM login_utilizadores WHERE codigo_utilizador=@Codigo_utilizador";
            cmd.Parameters.AddWithValue("@codigo_utilizador", textBox_codigo_unico.Text);
            sqlcon.Open();
            SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqladp.Fill(ds);
            sqlcon.Close();
            int count1 = ds.Tables[0].Rows.Count;
            if (count1 == 1)
            {
                Página_Principal frm_medicamentos = new Página_Principal(textBox_username_confirmação.Text);
                
                frm_medicamentos.Show();
            }
            else
            {
                MessageBox.Show("ERRO");
            }
        }

        private void button1_cu_Click(object sender, EventArgs e)
        {
            if (textBox_codigo_unico.PasswordChar == '●')
            {
                button2_cu.BringToFront();
                textBox_codigo_unico.PasswordChar = '\0';
            }
        }

        private void button2_cu_Click(object sender, EventArgs e)
        {
            if (textBox_codigo_unico.PasswordChar == '\0')
            {
                button1_cu.BringToFront();
                textBox_codigo_unico.PasswordChar = '●';
            }
        }
    }
}
