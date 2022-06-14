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
using System.Text.RegularExpressions;

namespace DLS_ALFEITE
{
    public partial class Definições : Form
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
        int id = 0;
        public Definições(string value)
        {
            InitializeComponent();
            Form_estilo();
            txb_username.Text = value;
            carregar_dados();
        }
        public void Form_estilo()
        {
            txb_fabricante.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_fabricante.Width, txb_fabricante.Height, 30, 30));
            txb_versao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_versao.Width, txb_versao.Height, 30, 30));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            txb_username.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_username.Width, txb_username.Height, 30, 30));
            cb_genero.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cb_genero.Width, cb_genero.Height, 30, 30));
            txb_email.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_email.Width, txb_email.Height, 30, 30));
            txb_nome.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_nome.Width, txb_nome.Height, 30, 30));
            txb_numero_telemovel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_numero_telemovel.Width, txb_numero_telemovel.Height, 30, 30));
            txb_password.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_password.Width, txb_password.Height, 30, 30));
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_guardar.Width, btn_guardar.Height, 30, 30));
            this.ActiveControl = panel2;
            txb_password.PasswordChar = '●';
            //validacao_dos_campo
            txb_numero_telemovel.MaxLength = 9;
            cb_genero.MaxLength = 1;
        }

        public void carregar_dados()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(connection);
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select id_utilizador,nome,username,password,genero,email,num_tel from Utilizadores WHERE username=@Username";
                cmd.Parameters.AddWithValue("@Username", txb_username.Text);
                sqlcon.Open();
                SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqladp.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    using (cmd)
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    id = rdr.GetInt32(0);
                                    txb_nome.Text = rdr.GetString(1);
                                    txb_password.Text = rdr.GetString(3);
                                    cb_genero.Text = rdr.GetString(5);
                                    txb_email.Text = rdr.GetString(6);
                                    txb_numero_telemovel.Text = rdr.GetString(7);
                                }
                            }
                        }
                    }
                    sqlcon.Close();
                }
                else
                {
                    MessageBox.Show("ERRO!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        bool ver = false;
        public void btn_guardar_Click(object sender, EventArgs e)
        {
            Verificacao();
            if (ver == false)
            {
                ver = true;
            }
            else
            {
                try
                {
                    string query = "UPDATE Utilizadores SET nome = '" + this.txb_nome.Text + "',password = '" + this.txb_password.Text + "',genero = '" + this.cb_genero.Text + "', email = '" + this.txb_email.Text + "',num_tel = '" + this.txb_numero_telemovel.Text + "' WHERE id_utilizador = @id ";
                    SqlConnection sqlCon = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader myreader;
                    sqlCon.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myreader.Read())
                    {

                    }
                    sqlCon.Close();
                    txb_password.PasswordChar = '●';
                    btn_verpassword.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_verpassword_Click(object sender, EventArgs e)
        {
            Login_Codigo frm_cd = new Login_Codigo(txb_username.Text);
            frm_cd.ShowDialog();
            btn_esconder_password.BringToFront();
            txb_password.PasswordChar = '\0';
        }

        private void btn_esconder_password_Click(object sender, EventArgs e)
        {
            if (txb_password.PasswordChar == '\0')
            {
                btn_verpassword.BringToFront();
                txb_password.PasswordChar = '●';
            }
        }

        public void Verificacao()
        {
            if (txb_username.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Username incorreto!");
            }
            if (cb_genero.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Género incorreto!");
            }
            if (txb_email.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Email incorreto!");
            }
            if (txb_numero_telemovel.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Número de telemóvel incorreto!");
            }
            if (txb_nome.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Nome incorreto!");
            }
            if (txb_password.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Password incorreto!");
            }
            //regular expression
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex obj = new Regex(strRegex);
            if (obj.IsMatch(txb_email.Text) == false)
            {
                ver = false;
                MessageBox.Show("Campo Email incorreto");
            }
            string strRegex1 = @"^(9[1236]\d) ?(\d{3}) ?(\d{3})";
            Regex obj1 = new Regex(strRegex1);
            if (obj1.IsMatch(txb_numero_telemovel.Text) == false)
            {
                ver = false;
                MessageBox.Show("Campo Número de telemóvel incorreto");
            }
        }
    }
}
