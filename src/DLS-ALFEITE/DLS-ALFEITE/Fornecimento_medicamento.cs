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
    public partial class Fornecimento_medicamento : Form
    {
        int id1 = 0;
        bool asa = true;
        public Fornecimento_medicamento(string id, string value1, string value2, string value3)
        {
            InitializeComponent();
            id1 = Convert.ToInt32(id);
            txb_denominacao.Text = value1;
            txb_principio_ativo.Text = value2;
            txb_lote.Text = value3;
            txb_lote.MaxLength = 5;
            dtp_data_fornecimento.MinDate = DateTime.Today;
            dtp_data_prevista_entrega.MinDate = DateTime.Today;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                    string query = "insert into fornecimento_medicamentos(id_fornecimento,data_fornecimento,data_entrega,quantidade_fornecimento,entidade,observacoes) VALUES( " + id1 + ", '" + this.dtp_data_fornecimento.Text + "','" + this.dtp_data_prevista_entrega.Text + "','" + this.txb_quantidade.Text + "','" + this.txb_entidade.Text + "','" + this.txb_observacoes.Text + "')";
                    SqlConnection sqlCon = new SqlConnection(connectionString);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void verificacao()
        {
            if (txb_denominacao.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Denominação incorreto!");
            }
            if (txb_principio_ativo.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Princípio/Ativo incorreto!");
            }
            if (dtp_data_fornecimento.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Validade incorreto!");
            }
            if (dtp_data_prevista_entrega.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Lote incorreto!");
            }
            if (txb_quantidade.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Quantidade incorreto!");
            }
            if (txb_entidade.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Fabricante incorreto!");
            }
            if (txb_lote.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Contacto do Fabricante incorreto!");
            }
            
        }
    }
}
