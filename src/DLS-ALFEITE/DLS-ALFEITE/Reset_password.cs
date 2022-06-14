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
            if (txb_codigo_unico.Text == a)
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
                    string query = "UPDATE Utilizadores SET password = '" + this.txb_comfirmacao_password.Text + "' WHERE username = @user ";
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
            if (txb_codigo_unico.Text == "Código do Email")
            {
                txb_codigo_unico.Text = "";
                txb_codigo_unico.PasswordChar = '●';
            }
        }

        private void txb_codigo_unico_Leave(object sender, EventArgs e)
        {
            if (txb_codigo_unico.Text == "")
            {
                txb_codigo_unico.Text = "Código do Email";
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
            cmd.Parameters.AddWithValue("@user", txb_username.Text);
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
            password = "ntceacwydarlnjqa";
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
                    txb_codigo_unico.Enabled = true;
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
    }
}
    