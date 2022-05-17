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
            string mainconn = ConfigurationManager.ConnectionStrings["Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;"].ConnectionString;
            try
            {
                SqlConnection sqlcon = new SqlConnection(mainconn);
                sqlcon.Open();
                string sqlquery = "select * from Medicamentos where Medicamentos = '" + textbox_searchbar.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sqlquery,sqlcon);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                sqlcon.Close();
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
            btn.HeaderText = "Ações";
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
        }
    }
}
