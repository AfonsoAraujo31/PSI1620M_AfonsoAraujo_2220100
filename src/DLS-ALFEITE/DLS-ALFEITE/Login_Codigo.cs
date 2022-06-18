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
using System.Net.Mail;
using System.Net;

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
            //textBox_username_confirmação.Enabled = false;
            textBox_username_confirmação.Text = value;
        }
        private string value { get; set; }
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        private void textBox_codigo_unico_Enter(object sender, EventArgs e)
        {
            if (textBox_codigo_unico.Text == "Código do Email")
            {
                textBox_codigo_unico.Text = "";
                textBox_codigo_unico.PasswordChar = '●';
            }
        }

        private void textBox_codigo_unico_Leave(object sender, EventArgs e)
        {
            if (textBox_codigo_unico.Text == "")
            {
                textBox_codigo_unico.Text = "Código do Email";
                textBox_codigo_unico.PasswordChar = '\0';
            }
        }
        public void btn_login_codigounico_Click(object sender, EventArgs e)
        {
            if (textBox_codigo_unico.Text == a)
            {
                Definições definições = new Definições(textBox_username_confirmação.Text);
                definições.btn_verpassword.BringToFront();
                definições.txb_password.PasswordChar = '\0';
                this.Close();
            }
            else
            {
                MessageBox.Show("Username ou código único errados!");
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
        string email1 = null;
        string nome1 = null;
        string a = null;
        private void email_Click(object sender, EventArgs e)
        {
            int length = 4;
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;
            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
                a = str_build.ToString();
            }
     
            SqlConnection sqlcon = new SqlConnection(connection);
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandText = $"SELECT username,email,nome FROM Utilizadores WHERE username=@user";
            cmd.Parameters.AddWithValue("@user", textBox_username_confirmação.Text);
            sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            int count1 = ds.Tables[0].Rows.Count;
            if (count1 == 1)
            {
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            email1 = rdr.GetString(1);
                            nome1 = rdr.GetString(2);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Username ou código único errados!");
            }
            sqlcon.Close();
            string to, from, password, mail;
            to = email1;
            from = "afonso16araujo@gmail.com";
            mail = "Caro:" + nome1 + ", solicitou a recuperação da sua palavra pass para o login no DLS-ALFEITE.\nCódigo Único: " + str_build + ".\nCaso não tenha feito o pedido de recuperação, verifique a segurança da sua conta contactando a equipa técnica.\n Obrigado!";
            password = "nzhujiikiursxgeo";
            if (email1.Trim() == string.Empty)
            {
                MessageBox.Show("Espaço em branco, por favor digite o seu E-mail!!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string palavra = "@gmail.com";
            if (to.Contains(palavra))
            {
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = mail;
                message.Subject = "Recuperação de Password";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from, password);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Email enviado", "E-Mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_codigo_unico.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Não digitou o E-mail corretamente. Lembre-se que so pode inserir E-mail's da Google do tipo: (...)@GMAIL.COM", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
