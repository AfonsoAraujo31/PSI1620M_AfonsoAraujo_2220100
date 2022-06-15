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
using System.Text.RegularExpressions;

namespace DLS_ALFEITE
{
    public partial class Editar_equipamento : Form
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
        int id1 = 0;
        bool ver = true;
        private readonly Equipamentos equipamentos;
        public Editar_equipamento(string id, string value, string value2, string value4, string value5, string value6, string value7, string value8, string value9, Equipamentos a)
        {
            InitializeComponent();
            Form_estilo();
            equipamentos = a;
            id1 = Convert.ToInt32(id);
            txb_denominacao.Text = value;
            txb_lote.Text = value2;
            txb_quantidade.Text = value4;
            txb_numero_serie.Text = value5;
            txb_fabricante.Text = value6;
            txb_contacto_fabricante.Text = value7;
            txb_observacoes.Text = value8;
            txb_setor.Text = value9;
        }
        public void Form_estilo()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //inputs_redondos
            txb_denominacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_numero_serie.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_numero_serie.Width, txb_numero_serie.Height, 12, 12));
            txb_lote.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_lote.Width, txb_lote.Height, 12, 12));
            txb_observacoes.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_observacoes.Width, txb_observacoes.Height, 20, 20));
            txb_contacto_fabricante.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_contacto_fabricante.Width, txb_contacto_fabricante.Height, 12, 12));
            txb_fabricante.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_fabricante.Width, txb_fabricante.Height, 12, 12));
            txb_quantidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_quantidade.Width, txb_quantidade.Height, 12, 12));
            txb_setor.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_setor.Width, txb_setor.Height, 12, 12));
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_guardar.Width, btn_guardar.Height, 12, 12));
            btn_cancelar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancelar.Width, btn_cancelar.Height, 12, 12));
            //validacao_dos_campos
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

        public void Verificacao()
        {
            if (txb_denominacao.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Denominação incorreto!");
            }
            if (txb_lote.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Lote incorreto!");
            }
            if (txb_numero_serie.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Número de série incorreto!");
            }
            if (txb_quantidade.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Quantidade incorreto!");
            }
            if (txb_fabricante.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Fabricante incorreto!");
            }
            if (txb_contacto_fabricante.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Contacto do Fabricante incorreto!");
            }
            if (txb_setor.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Setor incorreto!");
            }
            if (txb_lote.Text.Length < 5)
            {
                ver = false;
                MessageBox.Show("O campo lote deve conter cinco números");
            }
            if (txb_numero_serie.Text.Length < 9)
            {
                ver = false;
                MessageBox.Show("O campo Número de série deve conter nove números");
            }
            //regular expression
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex obj = new Regex(strRegex);
            if (obj.IsMatch(txb_contacto_fabricante.Text) == false)
            {
                ver = false;
                MessageBox.Show("Campo Contacto de fabricante incorreto");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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
                    string query = "UPDATE Equipamentos SET denominacao = '" + this.txb_denominacao.Text + "', lote = '" + this.txb_lote.Text + "', quantidade = '" + this.txb_quantidade.Text + "', numero_serie = '" + this.txb_numero_serie.Text + "', fabricante = '" + this.txb_fabricante.Text + "',email_tel_fabricante = '" + this.txb_contacto_fabricante.Text + "',setor = '" + this.txb_setor.Text + "' ,observacoes = '" + this.txb_observacoes.Text + "' WHERE id = @id ";
                    SqlConnection sqlCon = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@id", id1);
                    SqlDataReader myreader;
                    sqlCon.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myreader.Read())
                    {

                    }
                    equipamentos.atualiza_tabela();
                    equipamentos.listbox();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
