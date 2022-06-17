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
    public partial class Editar_medicamento : Form
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
        private readonly Medicamentos medicamentos;
        public Editar_medicamento(string id, string value, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, Medicamentos a)
        {
            InitializeComponent();
            Form_estilo();
            medicamentos = a;
            id1 = Convert.ToInt32(id);
            txb_denominacao.Text = value;
            txb_principio_ativo.Text = value2;
            dtp_validade.Text = value3;
            txb_lote.Text = value4;
            txb_quantidade.Text = value5;
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
            txb_principio_ativo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_principio_ativo.Width, txb_principio_ativo.Height, 12, 12));
            txb_lote.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_lote.Width, txb_lote.Height, 12, 12));
            txb_observacoes.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_observacoes.Width, txb_observacoes.Height, 20, 20));
            txb_contacto_fabricante.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_contacto_fabricante.Width, txb_contacto_fabricante.Height, 12, 12));
            txb_fabricante.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_fabricante.Width, txb_fabricante.Height, 12, 12));
            txb_quantidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_quantidade.Width, txb_quantidade.Height, 12, 12));
            txb_setor.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_setor.Width, txb_setor.Height, 12, 12));
            dtp_validade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_validade.Width, dtp_validade.Height, 12, 12));
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_guardar.Width, btn_guardar.Height, 12, 12));
            btn_cancelar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancelar.Width, btn_cancelar.Height, 12, 12));
            //validacao_dos_campos
            dtp_validade.MinDate = DateTime.Today;
            txb_lote.MaxLength = 5;
            txb_setor.MaxLength = 1;
        }


        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void verificacao()
        {
            if (txb_denominacao.Text == "")
            {
                ver = false;
                label_denominacao.Text = "Campo obrigatório!";
                label_denominacao.Visible = true;
            }
            if (txb_principio_ativo.Text == "")
            {
                ver = false;
                label_principio.Text = "Campo obrigatório!";
                label_principio.Visible = true;
            }
            if (dtp_validade.Text == "")
            {
                ver = false;
            }
            if (txb_lote.Text == "")
            {
                ver = false;
                label_lote.Text = "Campo obrigatório!";
                label_lote.Visible = true;
            }
            if (txb_quantidade.Text == "")
            {
                ver = false;
                label_quantidade.Text = "Campo obrigatório!";
                label_quantidade.Visible = true;
            }
            if (txb_fabricante.Text == "")
            {
                ver = false;
                label_fabricante.Text = "Campo obrigatório!";
                label_fabricante.Visible = true;
            }
            if (txb_contacto_fabricante.Text == "")
            {
                ver = false;
                label_contacto.Text = "Campo obrigatório!";
                label_contacto.Visible = true;
            }
            if (txb_setor.Text == "")
            {
                ver = false;
                label_setor.Text = "Campo obrigatório!";
                label_setor.Visible = true;
            }
            if (txb_lote.Text == "")
            {
                ver = false;
                label_lote.Text = "Campo obrigatório!";
                label_lote.Visible = true;
            }
            if (txb_lote.Text.Length < 5)
            {
                ver = false;
                label_lote.Text = "Campo deve conter";
                label_lote2.Text = "5 números!";
                label_lote.Visible = true;
                label_lote2.Visible = true;
            }
            //regular expression
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex obj = new Regex(strRegex);
            if (obj.IsMatch(txb_contacto_fabricante.Text) == false)
            {
                ver = false;
                label_contacto.Text = "Email inválido!";
                label_contacto.Visible = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            verificacao();
            if (ver == false)
            {
                ver = true;
            }
            else
            {
                try
                {
                    string query = "UPDATE Medicamentos SET denominacao = '" + this.txb_denominacao.Text + "',principio_ativo = '" + this.txb_principio_ativo.Text + "',validade = '" + this.dtp_validade.Text + "', lote = '" + this.txb_lote.Text + "',quantidade = '" + this.txb_quantidade.Text + "',fabricante = '" + this.txb_fabricante.Text + "',email_tel_fabricante = '" + this.txb_contacto_fabricante.Text + "',setor = '" + this.txb_setor.Text + "' ,observacoes = '" + this.txb_observacoes.Text + "' WHERE id = @id ";
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
                    medicamentos.atualiza_tabela();
                    medicamentos.listbox();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
