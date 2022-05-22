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
    public partial class Aquisição_equipamento : Form
    {
        int id1 = 0;
        public Aquisição_equipamento(string id, string value, string value1, string value2)
        {
            InitializeComponent();
            id1 = Convert.ToInt32(id);
            txb_denominacao.Text = value;
            txb_lote.Text = value1;
            txb_numero_serie.Text = value2;
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
            try
            {
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                string query = "insert into Aquisição_equipamentos(id_aquisicao,data_limite_rececao,quantidade_aquisicao,entidade,motivo) VALUES( " + id1 + ", '" + this.txb_data_rececao.Text + "','" + this.txb_quantidade.Text + "','" + this.txb_entidade.Text + "','" + this.txb_motivo.Text + "')";
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
