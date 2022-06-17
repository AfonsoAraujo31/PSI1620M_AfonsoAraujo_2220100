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
using System.Text.RegularExpressions;

namespace DLS_ALFEITE
{
    public partial class Registo : Form
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
        public Registo()
        {
            InitializeComponent();
            Form_estilo();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_utilizador as 'Id',username as 'Username', nome as 'Nome' FROM Utilizadores", sqlCon);
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
            dataGridView1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGridView1.Width, dataGridView1.Height, 30, 30));
            //eliminar
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btn_eliminar";
            btn.Text = "🗑";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 165;
            dataGridView1.Columns[3].Width = 30;
        }

        public void Form_estilo()
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 30, 30));
            txb_username.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_username.Width, txb_username.Height, 30, 30));
            cb_genero.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cb_genero.Width, cb_genero.Height, 30, 30));
            txb_email.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_email.Width, txb_email.Height, 30, 30));
            txb_nome.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_nome.Width, txb_nome.Height, 30, 30));
            txb_numero_telemovel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_numero_telemovel.Width, txb_numero_telemovel.Height, 30, 30));
            txb_password.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txb_password.Width, txb_password.Height, 30, 30));
            btn_guardar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_guardar.Width, btn_guardar.Height, 30, 30));
            btn_alterar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_alterar.Width, btn_alterar.Height, 30, 30));
            this.ActiveControl = panel2;
            //validacao_dos_campos
            txb_numero_telemovel.MaxLength = 9;
            cb_genero.MaxLength = 1;
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Berlin Sans FB", 15);
            dataGridView1.DefaultCellStyle.Font = new Font("Berlin Sans FB", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AllowUserToResizeRows = false;
        }
        bool ver = false;
        public void btn_guardar_Click(object sender, EventArgs e)
        {
            Verificacao();
            int identifica = 0;
            if (ver == false)
            {
                ver = true;
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(connection);
                    SqlCommand cmd1 = sqlCon.CreateCommand();
                    sqlCon.Open();
                    cmd1.CommandText = $"Select TOP 1 id_utilizador from Utilizadores ORDER BY id_utilizador DESC";
                    using (cmd1)
                    {
                        using (var rdr1 = cmd1.ExecuteReader())
                        {
                            if (rdr1.HasRows == true)
                            {
                                while (rdr1.Read())
                                {
                                    identifica = rdr1.GetInt32(0);
                                }
                            }
                        }
                    }
                    sqlCon.Close();
                    identifica = identifica + 1;
                    string query = "Insert into Utilizadores(id_utilizador,username,nome,password,genero,email,num_tel) VALUES('" + identifica + "','" + this.txb_username.Text + "','" + this.txb_nome.Text + "','" + this.txb_password.Text + "','" + this.cb_genero.Text + "','" + this.txb_email.Text + "','" + this.txb_numero_telemovel.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader myreader;
                    sqlCon.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myreader.Read())
                    {

                    }
                    sqlCon.Close();
                    txb_username.Text = "";
                    cb_genero.SelectedIndex = -1;
                    txb_email.Text = "";
                    txb_nome.Text = "";
                    txb_numero_telemovel.Text = "";
                    txb_password.Text = "";
                    Load_table();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Load_table()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_utilizador as 'Id',username as 'Username', nome as 'Nome' FROM Utilizadores", sqlCon);
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
        public void Verificacao()
        {
            if (txb_username.Text == "")
            {
                ver = false;
                label_username.Text = "Campo obrigatório!";
                label_username.Visible = true;
            }
            if (cb_genero.Text == "")
            {
                ver = false;
                label_genero.Text = "Campo obrigatório!";
                label_genero.Visible = true;
            }
            if (txb_email.Text == "")
            {
                ver = false;
                label_email.Text = "Campo obrigatório!";
                label_email.Visible = true;
            }
            if (txb_numero_telemovel.Text == "")
            {
                ver = false;
                label_tel.Text = "Campo obrigatório!";
                label_tel.Visible = true;
            }
            if (txb_nome.Text == "")
            {
                ver = false;
                label_nome.Text = "Campo obrigatório!";
                label_nome.Visible = true;
            }
            if (txb_password.Text == "")
            {
                ver = false;
                label_password.Text = "Campo obrigatório!";
                label_password.Visible = true;
            }
            //regular expression
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex obj = new Regex(strRegex);
            if (obj.IsMatch(txb_email.Text) == false)
            {
                ver = false;
                label_email.Text = "Email incorreto!";
                label_email.Visible = true;
            }
            string strRegex1 = @"^(9[1236]\d) ?(\d{3}) ?(\d{3})";
            Regex obj1 = new Regex(strRegex1);
            if (obj1.IsMatch(txb_numero_telemovel.Text) == false)
            {
                ver = false;
                label_tel.Text = "Telemóvel incorreto!";
                label_tel.Visible = true;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();

        }
        string id = null;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex < 0 ? 0 : e.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[idx];
            id = row.Cells["Id"].Value.ToString();
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                delete();
                Load_table();
            }
        }
        public void delete()
        {
            SqlConnection sqlCon = new SqlConnection(connection);
            SqlCommand cmd;
            try
            {
                using (cmd = new SqlCommand("DELETE FROM Utilizadores WHERE id_utilizador = @id", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_alterar.Visible = false;
            btn_guardar.Location = new Point(159, 611);
            txb_username.Text = "";
            cb_genero.SelectedIndex = -1;
            txb_email.Text = "";
            txb_nome.Text = "";
            txb_numero_telemovel.Text = "";
            txb_password.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_alterar.Visible = true;
            btn_guardar.Visible = false;
            btn_alterar.Location = new Point(159, 611);
            string id = null;
            id = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            SqlConnection sql = new SqlConnection(connection);
            using (sql)
            {
                SqlCommand cmd = sql.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT id_utilizador,username,nome,password,genero,email,num_tel FROM Utilizadores WHERE id_utilizador = @id";
                cmd.Parameters.AddWithValue("@id", id);
                pictureBox1.Tag = id;
                sql.Open();
                using (cmd)
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                txb_username.Text = rdr.GetString(1);
                                txb_nome.Text = rdr.GetString(2);
                                txb_password.Text = rdr.GetString(3);
                                cb_genero.Text = rdr.GetString(4);
                                txb_email.Text = rdr.GetString(5);
                                txb_numero_telemovel.Text = rdr.GetString(6);
                            }
                        }
                    }
                }
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Verificacao();
            if (ver == false)
            {
                ver = true;
            }
            else
            {
                try
                {
                    string id = null;
                    id = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                    SqlConnection sqlCon = new SqlConnection(connection);
                    string query = "UPDATE Utilizadores SET username = '" + this.txb_username.Text + "',nome = '" + this.txb_nome.Text + "',password = '" + this.txb_password.Text + "',genero = '" + this.cb_genero.Text + "',email = '" + this.txb_email.Text + "' ,num_tel = '" + this.txb_numero_telemovel.Text + "'WHERE id_utilizador = @id";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader myreader;
                    sqlCon.Open();
                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myreader.Read())
                    {

                    }
                    sqlCon.Close();
                    txb_username.Text = "";
                    cb_genero.SelectedIndex = -1;
                    txb_email.Text = "";
                    txb_nome.Text = "";
                    txb_numero_telemovel.Text = "";
                    txb_password.Text = "";
                    Load_table();
                    btn_alterar.Visible = false;
                    btn_guardar.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txb_username_TextChanged(object sender, EventArgs e)
        {
            label_username.Visible = false;
        }

        private void txb_nome_TextChanged(object sender, EventArgs e)
        {
            label_nome.Visible = false;
        }

        private void txb_password_TextChanged(object sender, EventArgs e)
        {
            label_password.Visible = false;
        }

        private void cb_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_genero.Visible = false;
        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {
            label_email.Visible = false;
        }

        private void txb_numero_telemovel_TextChanged(object sender, EventArgs e)
        {
            label_tel.Visible = false;
        }
    }
}
