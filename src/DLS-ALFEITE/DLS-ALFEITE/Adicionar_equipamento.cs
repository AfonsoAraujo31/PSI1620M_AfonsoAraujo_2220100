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
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        bool ver = true;
        private readonly Equipamentos equipamentos;
        public Adicionar_equipamento(Equipamentos a)
        {
            InitializeComponent();
            Form_estilo();
            equipamentos = a;
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
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancelar.Width, btn_cancelar.Height, 12, 12));
            btn_cancelar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancelar.Width, btn_cancelar.Height, 12, 12));
            //validacao_dos_campos
            txb_numero_serie.MaxLength = 9;
            txb_lote.MaxLength = 5;
            txb_setor.MaxLength = 1;
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
                label_denominacao.Text = "Campo obrigatório!";
                label_denominacao.Visible = true;
            }
            if (txb_numero_serie.Text == "")
            {
                ver = false;
                label_numero.Text = "Campo obrigatório!";
                label_numero.Visible = true;
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
            //regular expression
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex obj = new Regex(strRegex);
            if (obj.IsMatch(txb_contacto_fabricante.Text) == false)
            {
                ver = false;
                label_contacto.Text = "Email inválido!";
                label_contacto.Visible = true;
            }
            try
            {
                SqlConnection sqlcon = new SqlConnection(connection);
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
                    ver = false;
                    MessageBox.Show("Já existe um registo com esse nome ou com número de série igual.");
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (txb_lote.Text.Length < 5)
            {
                ver = false;
                label_lote.Text = "Campo deve conter";
                label_lote2.Text = "5 números!";
                label_lote.Visible = true;
                label_lote2.Visible = true;
            }
            if (txb_numero_serie.Text.Length < 9)
            {
                ver = false;
                label_numero.Text = "Campo deve conter 9 números!";
                label_numero.Visible = true;
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
                    string query = "insert into Equipamentos(denominacao,lote,quantidade,numero_serie,fabricante,email_tel_fabricante,observacoes,setor) VALUES('" + this.txb_denominacao.Text + "','" + this.txb_lote.Text + "','" + this.txb_quantidade.Text + "','" + this.txb_numero_serie.Text + "','" + this.txb_fabricante.Text + "','" + this.txb_contacto_fabricante.Text + "','" + this.txb_observacoes.Text + "','" + this.txb_setor.Text + "')";
                    SqlConnection sqlCon = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
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

        private void txb_denominacao_TextChanged(object sender, EventArgs e)
        {
            label_denominacao.Visible = false;
        }

        private void txb_numero_serie_TextChanged(object sender, EventArgs e)
        {
            label_numero.Visible = false;
        }

        private void txb_lote_TextChanged(object sender, EventArgs e)
        {
            label_lote.Visible = false;
        }

        private void txb_quantidade_TextChanged(object sender, EventArgs e)
        {
            label_quantidade.Visible = false;
        }

        private void txb_setor_TextChanged(object sender, EventArgs e)
        {
            label_setor.Visible = false;
            txb_setor.Text = txb_setor.Text.ToUpper();
        }

        private void txb_fabricante_TextChanged(object sender, EventArgs e)
        {
            label_fabricante.Visible = false;
        }

        private void txb_contacto_fabricante_TextChanged(object sender, EventArgs e)
        {
            label_contacto.Visible = false;
        }

        private void txb_lote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_setor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
