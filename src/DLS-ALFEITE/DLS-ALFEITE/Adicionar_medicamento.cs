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
    public partial class Adicionar_medicamento : Form
    {
        public Adicionar_medicamento()
        {
            InitializeComponent();
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
            try
            {
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                string query = "insert into Medicamentos(denominacao,principio_ativo,validade,lote,quantidade,fabricante,email_tel_fabricante,setor,observacoes) VALUES('"+this.txb_denominacao.Text+"','"+this.txb_principio_ativo.Text+"','"+this.txb_validade.Text+ "','" + this.txb_lote.Text + "','" + this.txb_quantidade.Text + "','" + this.txb_fabricante.Text + "','" + this.txb_contacto_fabricante.Text + "','" + this.txb_setor.Text + "','" + this.txb_observacoes.Text + "' )";
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
}
