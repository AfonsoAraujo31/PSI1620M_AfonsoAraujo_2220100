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

        int id1 = 0;
        bool asa = true;
        public Aquisição_medicamento(string id, string value1, string value2, string value3)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            id1 = Convert.ToInt32(id);
            txb_denominacao.Text = value1;
            txb_principio_ativo.Text = value2;
            txb_lote.Text = value3;
            txb_lote.MaxLength = 5;
            dtp_data_rececao.MinDate = DateTime.Today;
            texbox_redondas();
        }
        public void texbox_redondas()
        {
            txb_denominacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_principio_ativo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_lote.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_motivo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_motivo.Width, txb_motivo.Height, 20, 20));
            txb_quantidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_entidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            dtp_data_rececao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
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
                    string query = "insert into Aquisição_medicamentos(id_aquisicao,data_limite_rececao,quantidade_aquisicao,entidade,motivo) VALUES( " + id1 + ", '" + this.dtp_data_rececao.Text + "','" + this.txb_quantidade.Text + "','" + this.txb_entidade.Text + "','" + this.txb_motivo.Text + "')";
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
            if (dtp_data_rececao.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Data receção incorreto!");
            }
            if (txb_entidade.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Entidade incorreto!");
            }
            if (txb_motivo.Text == "")
            {
                asa = false;
                MessageBox.Show("Campo Motivo incorreto!");
            }
        }
    }
}
