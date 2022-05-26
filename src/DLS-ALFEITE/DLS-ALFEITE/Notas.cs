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
            try
            {
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                using (SqlConnection sqlCon1 = new SqlConnection(connectionString))
                {
                    sqlCon1.Open();
                    SqlCommand cmd1 = sqlCon1.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = $"select nota, nome_nota from notas inner join login_utilizadores ON Notas.id = login_utilizadores.id_utilizador where login_utilizadores.id_utilizador = @id";
                    cmd1.Parameters.AddWithValue("@id", 3);
                    cmd1.Parameters.AddWithValue("@nomedanota", label1.Text);
                    using (cmd1)
                    {
                        using (var rdr = cmd1.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    textBox1.Text = Convert.ToString(rdr.GetString(0));
                                }
                            }

                        }
                    }
                    sqlCon1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
