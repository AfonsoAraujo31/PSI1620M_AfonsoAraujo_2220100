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
    public partial class Aquisição_medicamento : Form
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
        public Aquisição_medicamento(string id, string value1, string value2, string value3)
        {
            InitializeComponent();
            Form_estilo();
            id1 = Convert.ToInt32(id);
            txb_denominacao.Text = value1;
            txb_principio_ativo.Text = value2;
            txb_lote.Text = value3;
        }
        public void Form_estilo()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //inputs_redondos
            txb_denominacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_principio_ativo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_principio_ativo.Width, txb_principio_ativo.Height, 12, 12));
            txb_lote.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_lote.Width, txb_lote.Height, 12, 12));
            txb_motivo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_motivo.Width, txb_motivo.Height, 20, 20));
            txb_quantidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_quantidade.Width, txb_quantidade.Height, 12, 12));
            cb_entidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cb_entidade.Width, cb_entidade.Height, 12, 12));
            dtp_data_rececao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_data_rececao.Width, dtp_data_rececao.Height, 12, 12));
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_guardar.Width, btn_guardar.Height, 12, 12));
            btn_cancelar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancelar.Width, btn_cancelar.Height, 12, 12));
            //validacao_dos_campos
            txb_lote.MaxLength = 5;
            dtp_data_rececao.MinDate = DateTime.Today;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("Campo Denominação incorreto!");
            }
            if (txb_principio_ativo.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Princípio/Ativo incorreto!");
            }
            if (txb_lote.Text == "")
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
            if (dtp_data_rececao.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Data receção incorreto!");
            }
            if (cb_entidade.Text == "")
            {
                ver = false;
                label_entidade.Text = "Campo obrigatório!";
                label_entidade.Visible = true;
            }
            if (txb_motivo.Text == "")
            {
                ver = false;
                label_motivo.Text = "Campo obrigatório!";
                label_motivo.Visible = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string query = "insert into Aquisicao_medicamentos(id_aquisicao,data_limite_rececao,quantidade_aquisicao,entidade,motivo) VALUES( " + id1 + ", '" + this.dtp_data_rececao.Text + "','" + this.txb_quantidade.Text + "','" + this.cb_entidade.Text + "','" + this.txb_motivo.Text + "')";
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
                    MessageBox.Show("Já existe um registo desse medicamento.");
                }
            }
        }

        private void txb_quantidade_TextChanged(object sender, EventArgs e)
        {
            label_quantidade.Visible = false;
        }

        private void txb_motivo_TextChanged(object sender, EventArgs e)
        {
            label_motivo.Visible = false;
        }

        private void cb_entidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_entidade.Visible = false;
        }

        private void txb_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
