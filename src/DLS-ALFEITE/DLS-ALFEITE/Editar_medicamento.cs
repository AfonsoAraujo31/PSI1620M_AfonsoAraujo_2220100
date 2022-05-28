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
        int id1 = 0;
        bool asa = true;
        private readonly Medicamentos medicamentos;
        public Editar_medicamento(string id, string value, string value2, string value3, string value4, string value5, string value6, string value7, string value8, string value9, Medicamentos a)
        {
            InitializeComponent();
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
            //this.medicamentos = medicamentos;
            medicamentos = a;
            dtp_validade.MinDate = DateTime.Today;
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

        public void btn_guardar_Click(object sender, EventArgs e)
        {
            verificacao();
            if(asa == false)
            {
                asa = true;
            }
            else
            {
                try
                {
                    string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                    string query = "UPDATE Medicamentos SET denominacao = '" + this.txb_denominacao.Text + "',principio_ativo = '" + this.txb_principio_ativo.Text + "',validade = '" + this.dtp_validade.Text + "', lote = '" + this.txb_lote.Text + "',quantidade = '" + this.txb_quantidade.Text + "',fabricante = '" + this.txb_fabricante.Text + "',email_tel_fabricante = '" + this.txb_contacto_fabricante.Text + "',setor = '" + this.txb_setor.Text + "' ,observacoes = '" + this.txb_observacoes.Text + "' WHERE id = @id ";
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
                    try
                    {
                        medicamentos.reload_tabela();
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
            if (dtp_validade.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Validade incorreto!");
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
        }
       
    }
}
