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
    public partial class Medicamentos : Form
    {
        public Medicamentos()
        {
            InitializeComponent();
            StyleDatagridview();
        }
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        private void Medicamentos_Load(object sender, EventArgs e)
        {
            try
            {
                    string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante',observacoes as 'Observações', setor as 'Setor' FROM Medicamentos", sqlCon);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);
                        //method 1 - direct method
                        dataGridView1.DataSource = dtbl;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            update();
        }
        void StyleDatagridview()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textbox_searchbar_Enter(object sender, EventArgs e)
        {
            if (textbox_searchbar.Text == "Search...")
            {
                textbox_searchbar.Text = "";
            }
        }

        private void textbox_searchbar_Leave(object sender, EventArgs e)
        {
            if (textbox_searchbar.Text == "")
            {
                textbox_searchbar.Text = "Search...";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
            try
            {
                dataGridView1.Columns.Clear();
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"SELECT denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante',observacoes as 'Observações', setor as 'Setor' FROM Medicamentos where denominacao like '" + textbox_searchbar.Text +"%'";

                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataTable dtbl = new DataTable();
                    adpt.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                update();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void update()
        {
            //eliminar
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btn_eliminar";
            btn.Text = "🗑";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            //editar
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "";
            btn1.Name = "btn_editar";
            btn1.Text = "🖉";
            btn1.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn1);
            //aquisição
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "";
            btn2.Name = "btn_aquisicao";
            btn2.Text = "➕";
            btn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn2);
            //fornecer
            DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
            btn3.HeaderText = "";
            btn3.Name = "btn_fornecer";
            btn3.Text = "➖";
            btn3.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn3);
            //tamanho das colunas
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[9].Width = 30;
            dataGridView1.Columns[10].Width = 30;
            dataGridView1.Columns[11].Width = 30;
            dataGridView1.Columns[12].Width = 30;
        }
        string nome = null;
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    nome = row.Cells["Denominação"].Value.ToString();
                }   
                delete();
            }
            else if(dataGridView1.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                
            }
            else if(dataGridView1.Columns[e.ColumnIndex].Name == "btn_aquisicao")
            {
                
            }
            else if(dataGridView1.Columns[e.ColumnIndex].Name == "btn_fornecer")
            {
                
            }
            else {
                //MessageBox.Show("1");
            }
        }
        public void btn_adicionar_medicamentos_Click(object sender, EventArgs e)
        {
            new Adicionar_medicamento().Show();
        }

        public void delete()
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString);
            SqlCommand cmd;
            try
            {
                using (cmd = new SqlCommand("DELETE FROM Medicamentos WHERE denominacao = @deno", sqlCon))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@deno", nome);
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textbox_searchbar_TextChanged(object sender, EventArgs e)
        {
            if(textbox_searchbar.Text == "")
            {
                string mainconn = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
                try
                {
                    dataGridView1.Columns.Clear();
                    using (SqlConnection sqlCon = new SqlConnection(connection))
                    {
                        sqlCon.Open();
                        SqlCommand cmd = sqlCon.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = $"SELECT denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante',observacoes as 'Observações', setor as 'Setor' FROM Medicamentos where denominacao like '" + textbox_searchbar.Text + "%'";

                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        DataTable dtbl = new DataTable();
                        adpt.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                    }
                    update();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

