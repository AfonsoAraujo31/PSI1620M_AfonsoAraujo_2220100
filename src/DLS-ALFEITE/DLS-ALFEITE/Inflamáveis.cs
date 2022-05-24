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
    public partial class Inflamáveis : Form
    {
        public Inflamáveis()
        {
            InitializeComponent();
            InitializeComponent();
            StyleDatagridview();
            //this.ActiveControl = labe l1;
        }
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        private void Inflamáveis_Load_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                using (SqlConnection sqlCon1 = new SqlConnection(connectionString))
                {
                    sqlCon1.Open();
                    SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', numero_serie as 'Número de Série',fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', setor as 'Setor', observacoes as 'Observações' FROM Inflamaveis", sqlCon1);
                    DataTable dtbl1 = new DataTable();
                    sqlDa1.Fill(dtbl1);
                    //method 1 - direct method
                    dataGridView1.DataSource = dtbl1;
                    sqlCon1.Close();
                }
                listbox();
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
                try
                {
                    string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                    using (SqlConnection sqlCon1 = new SqlConnection(connectionString))
                    {
                        sqlCon1.Open();
                        SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', setor as 'Setor', observacoes as 'Observações' FROM Medicamentos", sqlCon1);
                        DataTable dtbl1 = new DataTable();
                        sqlDa1.Fill(dtbl1);
                        //method 1 - direct method
                        dataGridView1.DataSource = dtbl1;
                        sqlCon1.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 130;
            dataGridView1.Columns[8].Width = 40;
            dataGridView1.Columns[9].Width = 160;
            dataGridView1.Columns[10].Width = 30;
            dataGridView1.Columns[11].Width = 30;
            dataGridView1.Columns[12].Width = 30;
            dataGridView1.Columns[13].Width = 30;
        }

        string id = null;
        string denominacao = null;
        string principio_ativo = null;
        string validade = null;
        string lote = null;
        string stock = null;
        string fabricante = null;
        string contacto_do_fabricante = null;
        string observacoes = null;
        string setor = null;

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = row.Cells["Id"].Value.ToString();
                }
                delete();
                reload_tabela();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = row.Cells["Id"].Value.ToString();
                }
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = row.Cells["Id"].Value.ToString();
                    denominacao = row.Cells["Denominação"].Value.ToString();
                    principio_ativo = row.Cells["Princípio/Ativo"].Value.ToString();
                    validade = row.Cells["Validade"].Value.ToString();
                    lote = row.Cells["Lote"].Value.ToString();
                    stock = row.Cells["stock"].Value.ToString();
                    fabricante = row.Cells["Fabricante"].Value.ToString();
                    contacto_do_fabricante = row.Cells["Contacto do Fabricante"].Value.ToString();
                    observacoes = row.Cells["Observações"].Value.ToString();
                    setor = row.Cells["Setor"].Value.ToString();
                }
                new Editar_medicamento(id, denominacao, principio_ativo, validade, lote, stock, fabricante, contacto_do_fabricante, observacoes, setor).Show();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_aquisicao")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = row.Cells["Id"].Value.ToString();
                }
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = row.Cells["Id"].Value.ToString();
                    denominacao = row.Cells["Denominação"].Value.ToString();
                    principio_ativo = row.Cells["Princípio/Ativo"].Value.ToString();
                    lote = row.Cells["Lote"].Value.ToString();
                }
                new Aquisição_medicamento(id, denominacao, principio_ativo, lote).Show();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_fornecer")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = row.Cells["Id"].Value.ToString();
                }
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = row.Cells["Id"].Value.ToString();
                    denominacao = row.Cells["Denominação"].Value.ToString();
                    principio_ativo = row.Cells["Princípio/Ativo"].Value.ToString();
                    lote = row.Cells["Lote"].Value.ToString();
                }
                new Fornecimento_medicamento(id, denominacao, principio_ativo, lote).Show();
            }
            else
            {
                //MessageBox.Show("1");
            }
        }
        public void btn_adicionar_medicamentos_Click(object sender, EventArgs e)
        {
            new Adicionar_medicamento().Show();
        }
        public void delete()
        {
            SqlConnection sqlCon1 = new SqlConnection(ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString);
            SqlCommand cmd1;
            try
            {
                using (cmd1 = new SqlCommand("DELETE FROM Medicamentos WHERE id = @id", sqlCon1))
                {
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@id", id);
                    sqlCon1.Open();
                    cmd1.ExecuteNonQuery();
                    sqlCon1.Close();
                }
                Medicamentos frm_med = new Medicamentos();
                frm_med.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textbox_searchbar_TextChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
            try
            {
                dataGridView1.Columns.Clear();
                using (SqlConnection sqlCon = new SqlConnection(mainconn))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"SELECT id as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', setor as 'Setor', observacoes as 'Observações' FROM Medicamentos where denominacao like '" + textbox_searchbar.Text + "%'";

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
        private void listbox()
        {
            string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
            //listbox1
            string Query = "SELECT TOP 4 denominacao, validade FROM Medicamentos ORDER BY validade ASC";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(Query, sqlCon);
            SqlDataReader myReader;
            try
            {
                sqlCon.Open();
                using (myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {

                        listBox1.Items.Add(string.Format("{0} ➡️ {1}", myReader["denominacao"].ToString(), myReader["validade"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //listbox2
            string Query2 = "SELECT denominacao, quantidade FROM Medicamentos WHERE quantidade <= 150";
            SqlConnection sqlCon2 = new SqlConnection(connectionString);
            SqlCommand cmd2 = new SqlCommand(Query2, sqlCon2);
            SqlDataReader myReader2;
            try
            {
                sqlCon2.Open();
                using (myReader2 = cmd2.ExecuteReader())
                {
                    while (myReader2.Read())
                    {

                        listBox2.Items.Add(string.Format("{0} ➡️ {1}", myReader2["denominacao"].ToString(), myReader2["quantidade"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void reload_tabela()
        {
            string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
            using (SqlConnection sqlCon1 = new SqlConnection(connectionString))
            {
                sqlCon1.Open();
                SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', setor as 'Setor', observacoes as 'Observações' FROM Medicamentos", sqlCon1);
                DataTable dtbl1 = new DataTable();
                sqlDa1.Fill(dtbl1);
                //method 1 - direct method
                dataGridView1.DataSource = dtbl1;
                sqlCon1.Close();
            }
        }
    }
}
