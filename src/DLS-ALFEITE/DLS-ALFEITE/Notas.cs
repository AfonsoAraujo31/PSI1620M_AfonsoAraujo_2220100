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

namespace DLS_ALFEITE
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
            notas_preecnher();
        }

        private void notas_preecnher()
        {
            string asas=null;
            Program.value = asas;
            try
            {
                Frm_login lg = new Frm_login();
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                using (SqlConnection sqlCon1 = new SqlConnection(connectionString))
                {
                    sqlCon1.Open();
                    SqlCommand cmd = new SqlCommand("select username,nota,nome_nota from Notas inner join login_utilizador on Notas.id = Utilizador.id_utilizador", sqlCon1);
                    cmd.Parameters.AddWithValue("username", asas);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        label1.Text = reader["nome_nota"].ToString();
                        textBox1.Text = reader["nota"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
