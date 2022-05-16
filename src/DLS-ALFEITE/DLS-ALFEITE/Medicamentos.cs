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
    public partial class Medicamentos : Form
    {
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            try
            {
                
                string connectionString = @"Server=devlab.thenotepad.eu;Database=PSI20M_AfonsoAraujo_2220100;User Id=U2220100;Password=UUvrK9MT;";
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Medicamentos", sqlCon);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);
                        //method 1 - direct method
                        dataGridView1.DataSource = dtbl;
     
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
