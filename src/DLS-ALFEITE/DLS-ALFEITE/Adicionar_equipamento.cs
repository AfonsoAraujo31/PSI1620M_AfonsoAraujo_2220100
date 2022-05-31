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
    public partial class Adicionar_equipamento : Form
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

        bool asa = true;
        private readonly Equipamentos equipamentos;
        public Adicionar_equipamento(Equipamentos a)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            equipamentos = a;
            txb_numero_serie.MaxLength = 9;
            txb_lote.MaxLength = 5;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            verificacao();
            if (asa == false)
            {
                asa = true;
            }
            else
            {
                try
                {
                    string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                    string query = "insert into Equipamentos(denominacao,lote,quantidade,numero_serie,fabricante,email_tel_fabricante,observacoes,setor) VALUES('" + this.txb_denominacao.Text + "','" + this.txb_lote.Text + "','" + this.txb_quantidade.Text + "','" + this.txb_numero_serie.Text + "','" + this.txb_fabricante.Text + "','" + this.txb_contacto_fabricante.Text + "','" + this.txb_observacoes.Text + "','" + this.txb_setor.Text + "')";
                    SqlConnection sqlCon = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader myreader;
                    sqlCon.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myreader.Read())
                    {

                    }
                    try
                    {
                        equipamentos.reload_tabela();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void verificacao()
        {
            if (txb_denominacao.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Denominação incorreto!");
            }
            if (txb_numero_serie.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Número de série incorreto!");
            }
            if (txb_lote.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Lote incorreto!");
            }
            if (txb_quantidade.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Quantidade incorreto!");
            }
            if (txb_fabricante.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Fabricante incorreto!");
            }
            if (txb_contacto_fabricante.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Contacto do Fabricante incorreto!");
            }
            if (txb_setor.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Setor incorreto!");
            }
            //regular expression
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex obj = new Regex(strRegex);
            if (obj.IsMatch(txb_contacto_fabricante.Text) == false)
            {
                asa = false;
                MessageBox.Show("Campo Contacto de fabricante incorreto");
            }
            try
            {
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                SqlConnection sqlcon = new SqlConnection(connectionString);
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT denominacao,lote,numero_serie FROM Equipamentos WHERE denominacao=@denominacao OR lote=@lote OR numero_serie=@numero_serie ";
                cmd.Parameters.AddWithValue("@denominacao", txb_denominacao.Text);
                cmd.Parameters.AddWithValue("@numero_serie", txb_numero_serie.Text);
                cmd.Parameters.AddWithValue("@lote", txb_lote.Text);
                sqlcon.Open();
                SqlDataAdapter sqladp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqladp.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count >= 1)
                {
                    asa = false;
                    MessageBox.Show("Já existe um registo com esse nome ou com número de série igual.");
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
