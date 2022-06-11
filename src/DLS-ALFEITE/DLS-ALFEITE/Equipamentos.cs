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
    public partial class Equipamentos : Form
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
        public Equipamentos()
        {
            InitializeComponent();
            Form_estilo();
        }
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        private void Equipamentos_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',lote as 'Lote', quantidade as 'Stock',numero_serie as 'Nº de Série', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto',observacoes as 'Observações', setor as 'Setor' FROM Equipamentos", sqlCon);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    sqlCon.Close();
                }
                listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            update();
        }
        public void listbox()
        {
            listBox8.Items.Clear();
            listBox7.Items.Clear();
            listBox6.Items.Clear();
            listBox5.Items.Clear();
            //listbox1
            string Query = "SELECT TOP 4 denominacao, quantidade FROM Equipamentos WHERE quantidade <= 20 ORDER BY quantidade ASC";
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(Query, sqlCon);
            SqlDataReader myReader;
            try
            {
                sqlCon.Open();
                using (myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        listBox8.Items.Add(myReader["denominacao"].ToString());
                        listBox7.Items.Add(string.Format("➡️ {0}", myReader["quantidade"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //listbox2
            string Query1 = "SELECT TOP 3 denominacao FROM Equipamentos ORDER BY id DESC";
            SqlConnection sqlCon1 = new SqlConnection(connection);
            SqlCommand cmd1 = new SqlCommand(Query1, sqlCon1);
            SqlDataReader myReader1;
            try
            {
                sqlCon1.Open();
                using (myReader1 = cmd1.ExecuteReader())
                {
                    while (myReader1.Read())
                    {
                        listBox6.Items.Add("Denominação:");
                        listBox5.Items.Add(string.Format(myReader1["denominacao"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Form_estilo()
        {
            this.ActiveControl = label2;
            //datagridview
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(52, 73, 94);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AllowUserToResizeRows = false;
            //inputs_redondos
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 30, 30));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5   .Height, 30, 30));
            btn_adicionar_medicamentos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_adicionar_medicamentos.Width, btn_adicionar_medicamentos.Height, 25, 30));
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
            dataGridView1.Columns[9].Width = 30;
            dataGridView1.Columns[10].Width = 30;
            dataGridView1.Columns[11].Width = 30;
            dataGridView1.Columns[12].Width = 30;
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
                    using (SqlConnection sqlCon = new SqlConnection(connection))
                    {
                        sqlCon.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',lote as 'Lote', quantidade as 'Stock',numero_serie as 'Nº de Série', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto',observacoes as 'Observações', setor as 'Setor' FROM Equipamentos", sqlCon);
                        DataTable dtbl = new DataTable();
                        adapter.Fill(dtbl);
                        //method 1 - direct method
                        dataGridView1.DataSource = adapter;
                        sqlCon.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        public void delete()
        {
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand cmd1, cmd2, cmd3;
            try
            {
                using (cmd1 = new SqlCommand("DELETE FROM Aquisição_equipamentos WHERE id_aquisicao = @id", sqlCon))
                {
                    cmd1.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    cmd1.ExecuteNonQuery();
                    sqlCon.Close();
                }
                using (cmd2 = new SqlCommand("DELETE FROM fornecimento_equipamento WHERE id_fornecimento = @id", sqlCon))
                {
                    cmd2.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    cmd2.ExecuteNonQuery();
                    sqlCon.Close();
                }
                using (cmd3 = new SqlCommand("DELETE FROM Equipamentos WHERE id = @id", sqlCon))
                {
                    cmd3.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    cmd3.ExecuteNonQuery();
                    sqlCon.Close();
                }
                Equipamentos equipamentos = new Equipamentos();
                equipamentos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listbox();
        }

        string id = null;
        string denominacao = null;
        string lote = null;
        string stock = null;
        string numero_serie = null;
        string fabricante = null;
        string contacto_do_fabricante = null;
        string observacoes = null;
        string setor = null;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            id = row.Cells["Id"].Value.ToString();
            denominacao = row.Cells["Denominação"].Value.ToString();
            lote = row.Cells["Lote"].Value.ToString();
            stock = row.Cells["Stock"].Value.ToString();
            numero_serie = row.Cells["Nº de série"].Value.ToString();
            fabricante = row.Cells["Fabricante"].Value.ToString();
            contacto_do_fabricante = row.Cells["Contacto"].Value.ToString();
            observacoes = row.Cells["Observações"].Value.ToString();
            setor = row.Cells["Setor"].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                id = row.Cells["Id"].Value.ToString();
                delete();
                atualiza_tabela();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                Editar_equipamento editar_equipamento = new Editar_equipamento(id, denominacao, lote, stock, numero_serie, fabricante, contacto_do_fabricante, observacoes, setor, this);
                editar_equipamento.Show();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_aquisicao")
            {
                Aquisição_equipamento aquisição_equipamento = new Aquisição_equipamento(id, denominacao, lote, numero_serie);
                aquisição_equipamento.Show();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_fornecer")
            {
                Fornecimento_equipamento fornecimento_equipamento = new Fornecimento_equipamento(id, denominacao, lote, numero_serie);
                fornecimento_equipamento.Show();
            }
            else
            {
                //MessageBox.Show("1");
            }
        }
        public void btn_adicionar_medicamentos_Click(object sender, EventArgs e)
        {
            Adicionar_equipamento adicionar_equipamento = new Adicionar_equipamento(this);
            adicionar_equipamento.Show();
        }
        private void textbox_searchbar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"SELECT id as 'Id', denominacao as 'Denominação',lote as 'Lote', quantidade as 'Stock',numero_serie as 'Nº de Série', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto',observacoes as 'Observações', setor as 'Setor' FROM Equipamentos where denominacao like '" + textbox_searchbar.Text + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void atualiza_tabela()
        {
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',lote as 'Lote', quantidade as 'Stock',numero_serie as 'Nº de Série', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto',observacoes as 'Observações', setor as 'Setor' FROM Equipamentos", sqlCon);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }
    }
}
