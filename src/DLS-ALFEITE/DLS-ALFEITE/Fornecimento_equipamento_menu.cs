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
    public partial class Fornecimento_equipamento_menu : Form
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
        bool check = false;
        public Fornecimento_equipamento_menu(bool value)
        {
            InitializeComponent();
            Form_estilo();
            check = value;
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_fornecimento as 'Id', denominacao as 'Denominação',numero_serie as 'Nº de Série',quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto', data_entrega as 'Data limite de receção', entidade as 'Entidade' FROM Equipamentos inner join Fornecimento_equipamentos ON Equipamentos.id = Fornecimento_equipamentos.id_fornecimento", sqlCon);
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
            update();
            if (check == true)
            {
                btn_aprovar.Visible = true;
                btn_rejeitar.Visible = true;
            }
        }
        public void Form_estilo()
        {
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AllowUserToResizeRows = false;
            //inputs_redondos
            txb_denominacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_numero_serie.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_lote.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_observacoes.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_observacoes.Width, txb_observacoes.Height, 20, 20));
            txb_contacto_fabricante.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_contacto_fabricante.Width, txb_contacto_fabricante.Height, 12, 12));
            txb_fabricante.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_fabricante.Width, txb_fabricante.Height, 12, 12));
            txb_quantidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            txb_entidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_denominacao.Width, txb_denominacao.Height, 12, 12));
            btn_aprovar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_aprovar.Width, btn_aprovar.Height, 12, 12));
            btn_rejeitar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_rejeitar.Width, btn_rejeitar.Height, 12, 12));
            this.ActiveControl = label1;
        }
        public void update()
        {
            //tamanho das colunas
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[7].Width = 80;
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
                    cmd.CommandText = $"SELECT id_fornecimento as 'Id', denominacao as 'Denominação',numero_serie,quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto', data_entrega as 'Data limite de receção', entidade as 'Entidade' FROM Equipamentos inner join Fornecimento_equipamentos ON Equipamentos.id = Fornecimento_equipamentos.id_fornecimento  where denominacao like '" + textbox_searchbar.Text + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                update();
                if (check == true)
                {
                    btn_aprovar.Visible = true;
                    btn_rejeitar.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_fornecimento as 'Id', denominacao as 'Denominação',numero_serie,quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto', data_entrega as 'Data limite de receção', entidade as 'Entidade' FROM Equipamentos inner join Fornecimento_equipamentos ON Equipamentos.id = Fornecimento_equipamentos.id_fornecimento", sqlCon);
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
                if (check == true)
                {
                    btn_aprovar.Visible = true;
                    btn_rejeitar.Visible = true;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id1 = null;
            id1 = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            SqlConnection sql = new SqlConnection(connection);
            using (sql)
            {
                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT id_fornecimento as 'Id', denominacao as 'Denominação',numero_serie,lote,quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto', data_entrega as 'Data limite de receção', entidade as 'Entidade',Fornecimento_equipamentos.observacoes FROM Equipamentos inner join Fornecimento_equipamentos ON Equipamentos.id = Fornecimento_equipamentos.id_fornecimento Where id_fornecimento = @id";
                cmd.Parameters.AddWithValue("@id", id1);
                pictureBox1.Tag = id1;
                sql.Open();
                using (cmd)
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                txb_denominacao.Text = rdr.GetString(1);
                                txb_numero_serie.Text = rdr.GetString(2);
                                txb_lote.Text = Convert.ToString(rdr.GetInt32(3));
                                txb_quantidade.Text = Convert.ToString(rdr.GetInt32(4));
                                txb_fabricante.Text = rdr.GetString(5);
                                txb_contacto_fabricante.Text = rdr.GetString(6);
                                dtp_data_limite_rececao.Text = rdr.GetString(7);
                                txb_entidade.Text = rdr.GetString(8);
                                txb_observacoes.Text = rdr.GetString(9);
                            }
                        }
                    }
                }
            }
        }
        int num = 0;
        private void btn_aprovar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag == null)
            {
                MessageBox.Show("Necessita de selecionar algum registo");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(connection);
                SqlCommand cmd;
                using (cmd = new SqlCommand("Select quantidade FROM Equipamentos WHERE id = @id", sqlCon))
                {
                    sqlCon.Open();
                    cmd.Parameters.AddWithValue("@id", pictureBox1.Tag);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                num = rdr.GetInt32(0);
                            }
                        }
                    }
                    sqlCon.Close();
                }
                using (cmd = new SqlCommand("UPDATE Equipamentos SET quantidade = @quantidade WHERE id = @id", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@id", pictureBox1.Tag);
                    cmd.Parameters.AddWithValue("@quantidade", num - Convert.ToInt32(txb_quantidade.Text));
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
                using (cmd = new SqlCommand("DELETE FROM Fornecimento_equipamentos WHERE id_fornecimento = @id", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@id", pictureBox1.Tag);
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
                using (sqlCon)
                {
                    sqlCon.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_fornecimento as 'Id', denominacao as 'Denominação',numero_serie as 'Nº de Série',lote as 'Lote',quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto', data_entrega as 'Data limite de receção', entidade as 'Entidade' FROM Equipamentos inner join Fornecimento_equipamentos ON Equipamentos.id = Fornecimento_equipamentos.id_fornecimento", sqlCon);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    sqlCon.Close();
                }
            }
        }

        private void btn_rejeitar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand cmd;
            using (cmd = new SqlCommand("DELETE FROM Fornecimento_equipamentos WHERE id_fornecimento = @id", sqlCon))
            {
                cmd.Parameters.AddWithValue("@id", pictureBox1.Tag);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            using (sqlCon)
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_fornecimento as 'Id', denominacao as 'Denominação',numero_serie as 'Nº de Série',lote as 'Lote',quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto', data_entrega as 'Data limite de receção', entidade as 'Entidade' FROM Equipamentos inner join Fornecimento_equipamentos ON Equipamentos.id = Fornecimento_equipamentos.id_fornecimento", sqlCon);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                sqlCon.Close();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
        }
    }
}
