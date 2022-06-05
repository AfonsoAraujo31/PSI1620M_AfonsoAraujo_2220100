﻿using System;
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
             int nleftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nwidthEllipse,
             int nHeightEllipse
        );

        int id1 = 0;
        bool ver = true;
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        public Fornecimento_medicamento(string id, string value1, string value2, string value3)
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
            txb_observacoes.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_observacoes.Width, txb_observacoes.Height, 20, 20));
            txb_quantidade.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_quantidade.Width, txb_quantidade.Height, 12, 12));
            txb_entidade.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_entidade.Width, txb_entidade.Height, 12, 12));
            txb_lote.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_lote.Width, txb_lote.Height, 12, 12));
            dtp_data_fornecimento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_data_fornecimento.Width, dtp_data_fornecimento.Height, 12, 12));
            dtp_data_prevista_entrega.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_data_prevista_entrega.Width, dtp_data_prevista_entrega.Height, 12, 12));
            //validacao_dos_campos
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
            if (ver == false)
            {
                ver = true;
            }
            else
            {
                try
                {
                    string query = "insert into fornecimento_medicamentos(id_fornecimento,data_fornecimento,data_entrega,quantidade_fornecimento,entidade,observacoes) VALUES( " + id1 + ", '" + this.dtp_data_fornecimento.Text + "','" + this.dtp_data_prevista_entrega.Text + "','" + this.txb_quantidade.Text + "','" + this.txb_entidade.Text + "','" + this.txb_observacoes.Text + "')";
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Já existe um registo desse medicamento.");
                }
            }
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
                MessageBox.Show("Campo Quantidade incorreto!");
            }
            if (txb_entidade.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Fabricante incorreto!");
            }
            if (txb_lote.Text == "")
            {
                ver = false;
                MessageBox.Show("Campo Lote incorreto!");
            }
            
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
