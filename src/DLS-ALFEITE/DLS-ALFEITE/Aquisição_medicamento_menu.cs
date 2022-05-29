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
    public partial class Aquisição_medicamento_menu : Form
    {
        public Aquisição_medicamento_menu()
        {
            InitializeComponent();
            StyleDatagridview();
            inputes();
            try
            {
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                using (SqlConnection sqlCon1 = new SqlConnection(connectionString))
                {
                    sqlCon1.Open();
                    SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT id_aquisicao as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_aquisição as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_limite_rececao as 'Data limite de receção', entidade as 'Entidade' FROM Medicamentos inner join Aquisição_medicamentos ON Medicamentos.id = Aquisição_medicamentos.id_aquisicao", sqlCon1);
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
        }
        DataGridViewCheckBoxColumn btn;
        public void update()
        {
            btn = new DataGridViewCheckBoxColumn();
            btn.HeaderText = "";
            btn.Name = "btn_selecionado";
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
            dataGridView1.Columns.Add(btn);
        }
        string id = null;
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
                        SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT id_aquisicao as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_aquisição as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_limite_rececao as 'Data limite de receção', entidade as 'Entidade' FROM Medicamentos inner join Aquisição_medicamentos ON Medicamentos.id = Aquisição_medicamentos.id_aquisicao", sqlCon1);
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
                    cmd.CommandText = $"SELECT id_aquisicao as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_aquisição as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_limite_rececao as 'Data limite de receção', entidade as 'Entidade' FROM Medicamentos inner join Aquisição_medicamentos ON Medicamentos.id = Aquisição_medicamentos.id_aquisicao where denominacao like '" + textbox_searchbar.Text + "%'";

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

        private void inputes()
        {
            txb_fabricante.Enabled = false;
            txb_princpio_ativo.Enabled = false;
            txb_contacto_fabricante.Enabled = false;
            txb_entidade.Enabled=   false;
            txb_fabricante.Enabled = false;
            txb_lote.Enabled = false;   
            txb_motivo.Enabled = false;    
            txb_quantidade.Enabled = false; 
            txb_denominacao.Enabled = false;
            dtp_data_limite_rececao.Enabled = false;
        }

        public void reload_tabela()
        {
            string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
            using (SqlConnection sqlCon1 = new SqlConnection(connectionString))
            {
                string a = null;
                sqlCon1.Open();
                SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT id_aquisicao as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_aquisição as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_limite_rececao as 'Data limite de receção', entidade as 'Entidade' FROM Medicamentos inner join Aquisição_medicamentos ON Medicamentos.id = Aquisição_medicamentos.id_aquisicao", sqlCon1);
                DataTable dtbl1 = new DataTable();
                sqlDa1.Fill(dtbl1);
                //method 1 - direct method
                dataGridView1.DataSource = dtbl1;
                sqlCon1.Close();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_selecionado")
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if ((Convert.ToBoolean(row.Cells[1].Value) == true))
                        {
                            id = row.Cells["Id"].Value.ToString();
                            SqlConnection sql = new SqlConnection(connectionString);
                            using (sql)
                            {
                                SqlCommand cmd = sql.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = $"SELECT id_aquisicao as 'Id', denominacao as 'Denominação',principio_ativo as 'Princípio/Ativo',quantidade_aquisição as 'Qtd', fabricante as 'Fabricante',email_tel_fabricante as 'Contacto do Fabricante', data_limite_rececao as 'Data limite de receção', entidade as 'Entidade',lote,motivo FROM Medicamentos inner join Aquisição_medicamentos ON Medicamentos.id = Aquisição_medicamentos.id_aquisicao Where id_aquisicao = @id";
                                cmd.Parameters.AddWithValue("@id", id);
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
                                                txb_fabricante.Text = rdr.GetString(4);
                                                txb_contacto_fabricante.Text = rdr.GetString(5);
                                                dtp_data_limite_rececao.Text = rdr.GetString(6);
                                                txb_entidade.Text = rdr.GetString(7);
                                                txb_lote.Text = Convert.ToString(rdr.GetInt32(8));
                                                txb_motivo.Text = rdr.GetString(9);
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }
                   
                }
                else
                {
                    //MessageBox.Show("1");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == false)
                    {
                        cb.Checked = true;
                    }
                    else
                    {
                        cb.Checked = false;
                    }                    
                }   
            }
        }
    }
}
