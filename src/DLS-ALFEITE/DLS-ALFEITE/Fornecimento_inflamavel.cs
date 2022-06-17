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
    public partial class Fornecimento_inflamaveis : Form
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
        int stock = 0;
        int id1 = 0;
        bool ver = true;
        public Fornecimento_inflamaveis(string id, string value1, string value2, string value3, string value4)
        {
            InitializeComponent();
            Form_estilo();
            id1 = Convert.ToInt32(id);
            txb_denominacao.Text = value1;
            txb_numero_serie.Text = value2;
            txb_lote.Text = value3;
            stock = Convert.ToInt32(value4);
        }
        public void Form_estilo()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //inputs_redondos
            txb_denominacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_numero_serie.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_numero_serie.Width, txb_numero_serie.Height, 12, 12));
            txb_lote.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_lote.Width, txb_lote.Height, 12, 12));
            txb_observacoes.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_observacoes.Width, txb_observacoes.Height, 12, 12));
            txb_quantidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_quantidade.Width, txb_quantidade.Height, 12, 12));
            cb_entidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cb_entidade.Width, cb_entidade.Height, 12, 12));
            dtp_data_fornecimento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_data_fornecimento.Width, dtp_data_fornecimento.Height, 12, 12));
            dtp_data_prevista_entrega.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_data_prevista_entrega.Width, dtp_data_prevista_entrega.Height, 12, 12));
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_guardar.Width, btn_guardar.Height, 12, 12));
            btn_cancelar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancelar.Width, btn_cancelar.Height, 12, 12));
            //validacao_dos_campos
            txb_lote.MaxLength = 5;
            dtp_data_fornecimento.MinDate = DateTime.Today;
            dtp_data_prevista_entrega.MinDate = DateTime.Today;
            txb_numero_serie.MaxLength = 9;
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
            if (txb_quantidade.Text != "")
            {
                if (stock - Convert.ToInt32(txb_quantidade.Text) < 0)
                {
                    ver = false;
                    label_quantidade.Text = "Stock indesponível!";
                    label_quantidade.Visible = true;
                }
            }
            if (txb_denominacao.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Denominação incorreto!");
            }
            if (txb_numero_serie.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo ´Número de série incorreto!");
            }
            if (dtp_data_fornecimento.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Validade incorreto!");
            }
            if (dtp_data_prevista_entrega.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Lote incorreto!");
            }
            if (txb_quantidade.Text == "")
            {
                ver = false;
                label_quantidade.Text = "Campo obrigatório!";
                label_quantidade.Visible = true;
            }
            if (cb_entidade.Text == "")
            {
                ver = false;
                label_entidade.Text = "Campo obrigatório!";
                label_entidade.Visible = true;
            }
            if (txb_lote.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Contacto do Fabricante incorreto!");
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
                    string query = "insert into Fornecimento_inflamaveis(id_fornecimento,data_fornecimento,data_entrega,quantidade_fornecimento,entidade,observacoes) VALUES( " + id1 + ", '" + this.dtp_data_fornecimento.Text + "','" + this.dtp_data_prevista_entrega.Text + "','" + this.txb_quantidade.Text + "','" + this.cb_entidade.Text + "','" + this.txb_observacoes.Text + "')";
                    SqlConnection sqlCon = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader myreader;
                    sqlCon.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myreader.Read())
                    {

                    }
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Já existe um registo desse inflamável.");
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_quantidade_TextChanged(object sender, EventArgs e)
        {
            label_quantidade.Visible = false;
        }

        private void cb_entidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_entidade.Visible = false;
        }
    }
}
