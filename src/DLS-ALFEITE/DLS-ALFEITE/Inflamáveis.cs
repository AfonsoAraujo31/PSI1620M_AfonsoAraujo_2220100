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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
             int nleftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nwidthEllipse,
             int nHeightEllipse
        );
        private string connection = ConfigurationManager.ConnectionStrings["PSI20M_AfonsoAraujo_2220100"].ConnectionString;
        public Inflamáveis()
        {
            InitializeComponent();
            Form_estilo();
        }
        private void Inflamáveis_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', numero_serie as 'Número de série', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', setor as 'Setor', observacoes as 'Observações' FROM Inflamaveis", sqlCon);
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
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));
            btn_adicionar_inflamavel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_adicionar_inflamavel.Width, btn_adicionar_inflamavel.Height, 25, 30));
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
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', numero_serie as 'Número de série', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', setor as 'Setor', observacoes as 'Observações' FROM Inflamaveis", sqlCon);
                        DataTable dtbl = new DataTable();
                        adapter.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        sqlCon.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                    cmd.CommandText = $"SELECT id as 'Id', denominacao as 'Denominação',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', numero_serie as 'Número de série', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', setor as 'Setor', observacoes as 'Observações' FROM Inflamaveis where denominacao like '" + textbox_searchbar.Text + "%'";
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
            btn2.Text = "🛒";
            btn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn2);
            //fornecer
            DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
            btn3.HeaderText = "";
            btn3.Name = "btn_fornecer";
            btn3.Text = "🚚";
            btn3.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn3);
            //tamanho das colunas
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[10].Width = 30;
            dataGridView1.Columns[11].Width = 30;
            dataGridView1.Columns[12].Width = 30;
            dataGridView1.Columns[13].Width = 30;

        }

        public void listbox()
        {
            listBox8.Items.Clear(); 
            listBox7.Items.Clear();
            listBox6.Items.Clear();
            listBox5.Items.Clear();
            //listbox1
            string Query = "SELECT TOP 3 denominacao, validade FROM Inflamaveis";
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
                        listBox7.Items.Add(string.Format("➡️ {0}", myReader["validade"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //listbox2
            string Query2 = "SELECT TOP 3 denominacao, quantidade FROM Inflamaveis WHERE quantidade <= 150 ORDER BY quantidade ASC";
            SqlConnection sqlCon2 = new SqlConnection(connection);
            SqlCommand cmd2 = new SqlCommand(Query2, sqlCon2);
            SqlDataReader myReader2;
            try
            {
                sqlCon2.Open();
                using (myReader2 = cmd2.ExecuteReader())
                {
                    while (myReader2.Read())
                    {
                        listBox6.Items.Add(myReader2["denominacao"].ToString());
                        listBox5.Items.Add(string.Format("➡️ {0}", myReader2["quantidade"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        string id = null;
        string denominacao = null;
        string validade = null;
        string lote = null;
        string stock = null;
        string numero_serie = null;
        string fabricante = null;
        string contacto_do_fabricante = null;
        string observacoes = null;
        string setor = null;

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex < 0 ? 0 : e.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[idx];
            id = row.Cells["Id"].Value.ToString();
            denominacao = row.Cells["Denominação"].Value.ToString();
            validade = row.Cells["Validade"].Value.ToString();
            lote = row.Cells["Lote"].Value.ToString();
            stock = row.Cells["stock"].Value.ToString();
            numero_serie = row.Cells["Número de série"].Value.ToString();
            fabricante = row.Cells["Fabricante"].Value.ToString();
            contacto_do_fabricante = row.Cells["Contacto do Fabricante"].Value.ToString();
            observacoes = row.Cells["Observações"].Value.ToString();
            setor = row.Cells["Setor"].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                id = row.Cells["Id"].Value.ToString();
                delete();
                atualiza_tabela();
                listbox();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                Editar_inflamavel editar_inflamavel = new Editar_inflamavel(id, denominacao, validade, lote, stock, numero_serie, fabricante, contacto_do_fabricante, observacoes, setor, this);
                editar_inflamavel.ShowDialog();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_aquisicao")
            {
                Aquisição_inflamavel aquisição_inflamavel = new Aquisição_inflamavel(id, denominacao, lote, numero_serie);
                aquisição_inflamavel.ShowDialog();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_fornecer")
            {
                Fornecimento_inflamaveis fornecimento_inflamavel = new Fornecimento_inflamaveis(id, denominacao, numero_serie, lote, stock);
                fornecimento_inflamavel.ShowDialog();
            }
            else
            {
                //MessageBox.Show("1");
            }
        }
        public void atualiza_tabela()
        {
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id as 'Id', denominacao as 'Denominação',validade as 'Validade', lote as 'Lote',quantidade as 'Stock', numero_serie as 'Número de série', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', setor as 'Setor', observacoes as 'Observações' FROM Inflamaveis", sqlCon);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        public void delete()
        {
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand cmd1, cmd2, cmd3;
            try
            {
                using (cmd1 = new SqlCommand("DELETE FROM Aquisicao_inflamaveis WHERE id_aquisicao = @id", sqlCon))
                {
                    cmd1.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    cmd1.ExecuteNonQuery();
                    sqlCon.Close();
                }
                using (cmd2 = new SqlCommand("DELETE FROM Fornecimento_inflamaveis WHERE id_fornecimento = @id", sqlCon))
                {
                    cmd2.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    cmd2.ExecuteNonQuery();
                    sqlCon.Close();
                }
                using (cmd3 = new SqlCommand("DELETE FROM Inflamaveis WHERE id = @id", sqlCon))
                {
                    cmd3.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    cmd3.ExecuteNonQuery();
                    sqlCon.Close();
                }
                Medicamentos medicamentos = new Medicamentos();
                medicamentos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listbox();
        }

        private void btn_adicionar_inflamavel_Click(object sender, EventArgs e)
        { 
            Adicionar_inflamavel adicionar_inflamavel = new Adicionar_inflamavel(this);
            adicionar_inflamavel.ShowDialog();
        }
    }
}
