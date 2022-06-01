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
    public partial class Fornecimento_inflamavel_menu : Form
    {
        public Fornecimento_inflamavel_menu()
        {
            InitializeComponent();
            StyleDatagridview();
            try
            {
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                using (SqlConnection sqlCon1 = new SqlConnection(connectionString))
                {
                    sqlCon1.Open();
                    SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT id_fornecimento as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_fornecimento as 'Data do Fornecimento', entidade as 'Entidade' FROM Medicamentos inner join fornecimento_medicamentos ON Medicamentos.id = fornecimento_medicamentos.id_fornecimento", sqlCon1);
                    DataTable dtbl1 = new DataTable();
                    sqlDa1.Fill(dtbl1);
                    dataGridView1.DataSource = dtbl1;
                    sqlCon1.Close();
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
            dataGridView1.AllowUserToResizeRows = false;
        }
        public void update()
        {
            //tamanho das colunas
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Columns[0].Width = 15;
            dataGridView1.Columns[1].Width = 55;
            dataGridView1.Columns[2].Width = 55;
            dataGridView1.Columns[3].Width = 25;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 70;
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
                    cmd.CommandText = $"SELECT id_fornecimento as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_fornecimento as 'Data do Fornecimento', entidade as 'Entidade' FROM Medicamentos inner join fornecimento_medicamentos ON Medicamentos.id = fornecimento_medicamentos.id_fornecimento where denominacao like '" + textbox_searchbar.Text + "%'";

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
                        SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT id_fornecimento as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_fornecimento as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_fornecimento as 'Data do Fornecimento', entidade as 'Entidade' FROM Medicamentos inner join fornecimento_medicamentos ON Medicamentos.id = fornecimento_medicamentos.id_fornecimento", sqlCon1);
                        DataTable dtbl1 = new DataTable();
                        sqlDa1.Fill(dtbl1);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id1 = null;
            id1 = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
            SqlConnection sql = new SqlConnection(connectionString);
            using (sql)
            {
                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT id_fornecimento as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_fornecimento as 'Qtd', lote,fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_fornecimento as 'Data do Fornecimento', entidade as 'Entidade',fornecimento_medicamentos.observacoes FROM Medicamentos inner join fornecimento_medicamentos ON Medicamentos.id = fornecimento_medicamentos.id_fornecimento Where id_fornecimento = @id";
                cmd.Parameters.AddWithValue("@id", id1);
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
                                txb_princpio_ativo.Text = rdr.GetString(2);
                                txb_quantidade.Text = Convert.ToString(rdr.GetInt32(3));
                                txb_lote.Text = Convert.ToString(rdr.GetInt32(4));
                                txb_fabricante.Text = rdr.GetString(5);
                                txb_contacto_fabricante.Text = rdr.GetString(6);
                                dtp_data_fornecimento.Text = rdr.GetString(7);
                                txb_entidade.Text = rdr.GetString(8);
                            }
                        }
                    }
                }
            }
        }
    }
}
