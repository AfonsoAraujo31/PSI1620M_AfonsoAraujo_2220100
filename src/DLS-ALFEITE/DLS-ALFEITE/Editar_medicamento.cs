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
    public partial class Editar_medicamento : Form
    {
        int id1 = 0;
        public Editar_medicamento(string id, string value, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9)
        {
            InitializeComponent();
            int id1 = Int32.Parse(id);
            if (Int32.TryParse(id, out id1))
            {
                // you know that the parsing attempt
                // was successful
            }
            txb_denominacao.Text = value;
            txb_principio_ativo.Text = value2;
            txb_validade.Text = value3;
            txb_lote.Text = value4;
            txb_quantidade.Text = value5;
            txb_fabricante.Text = value6;
            txb_contacto_fabricante.Text = value7;
            txb_observacoes.Text = value8;
            txb_setor.Text = value9;
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
                string query = "UPDATE Medicamentos SET denominacao = '" + this.txb_denominacao.Text + "',principio_ativo = '" + this.txb_principio_ativo.Text + "',validade = '" + this.txb_validade.Text + "', lote = '" + this.txb_lote.Text + "',quantidade = '" + this.txb_quantidade.Text + "',fabricante = '" + this.txb_fabricante.Text + "',email_tel_fabricante = '" + this.txb_contacto_fabricante.Text + "',setor = '" + this.txb_observacoes.Text + "' ,observacoes = '" + this.txb_setor.Text + "' WHERE id = @id1 ";
                SqlConnection sqlCon = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@id", id1);
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
