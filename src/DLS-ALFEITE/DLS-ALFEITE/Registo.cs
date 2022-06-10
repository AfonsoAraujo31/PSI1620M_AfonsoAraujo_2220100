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
    public partial class Registo : Form
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
        public Registo()
        {
            InitializeComponent();
            Form_estilo();
        }

        public void Form_estilo()
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            txb_username.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_username.Width, txb_username.Height, 30, 30));
            cb_genero.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cb_genero.Width, cb_genero.Height, 30, 30));
            txb_email.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_email.Width, txb_email.Height, 30, 30));
            txb_nome.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_nome.Width, txb_nome.Height, 30, 30));
            txb_numero_telemovel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_numero_telemovel.Width, txb_numero_telemovel.Height, 30, 30));
            txb_password.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_password.Width, txb_password.Height, 30, 30));
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_guardar.Width, btn_guardar.Height, 30, 30));
            txb_codigo_unico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_codigo_unico.Width, txb_codigo_unico.Height, 30, 30));
            this.ActiveControl = panel2;
            //validacao_dos_campos
            txb_codigo_unico.MaxLength = 4;
            txb_numero_telemovel.MaxLength = 9;
            cb_genero.MaxLength = 1;
        }
        bool ver = false;
        public void btn_guardar_Click(object sender, EventArgs e)
        {
            Verificacao();
            int identifica = 0;
            if (ver == false)
            {
                ver = true;
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(connection);
                    SqlCommand cmd1 = sqlCon.CreateCommand();
                    sqlCon.Open();
                    cmd1.CommandText = $"Select count(id_utilizador) from login_utilizadores";
                    using (cmd1)
                    {
                        using (var rdr1 = cmd1.ExecuteReader())
                        {
                            if (rdr1.HasRows == true)
                            {
                                while (rdr1.Read())
                                {
                                    identifica = rdr1.GetInt32(0);

                                }
                            }
                        }
                    }
                    sqlCon.Close();
                    identifica = identifica + 1;
                    string query = "Insert into login_utilizadores(id_utilizador,username,nome,password,genero,email,num_tel,codigo_unico) VALUES('" + identifica + "','" + this.txb_username.Text + "','" + this.txb_nome.Text + "','" + this.txb_password.Text + "','" + this.cb_genero.Text + "','" + this.txb_email.Text + "','" + this.txb_numero_telemovel.Text + "','" + this.txb_codigo_unico.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader myreader;
                    sqlCon.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myreader.Read())
                    {

                    }
                    sqlCon.Close();
                    txb_username.Text = "";
                    cb_genero.Text = "";
                    txb_email.Text = "";
                    txb_nome.Text = "";
                    txb_numero_telemovel.Text = "";
                    txb_password.Text = "";
                    txb_codigo_unico.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            if (txb_codigo_unico.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Código Único incorreto!");
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
