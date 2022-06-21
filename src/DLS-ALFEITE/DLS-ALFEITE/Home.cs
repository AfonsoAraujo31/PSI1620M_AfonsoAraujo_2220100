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
    public partial class Home : Form
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
        int len = 0;
        string text;
        public Home()
        {
            InitializeComponent();
            contas();
            text = label5.Text;
            len = text.Length;
            label5.Text = "";
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 100, 100));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 100, 100));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 100, 100));
            panel_stock.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_stock.Width, panel_stock.Height, 80, 80));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void contas()
        {
            string Query = "SELECT SUM(quantidade) FROM Medicamentos";
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
                        int b = myReader.GetInt32(0);
                        //label_medicamentos.Text = Convert.ToString(myReader.GetInt32(0));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            sqlCon.Close();

            Query = "SELECT SUM(quantidade) FROM Equipamentos";
            cmd = new SqlCommand(Query, sqlCon);
            try
            {
                sqlCon.Open();
                using (myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        label_equipamentos.Text = Convert.ToString(myReader.GetInt32(0));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            sqlCon.Close();

            Query = "SELECT SUM(quantidade) FROM Inflamaveis";
            cmd = new SqlCommand(Query, sqlCon);
            try
            {
                sqlCon.Open();
                using (myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        label_inflamaveis.Text = Convert.ToString(myReader.GetInt32(0));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            sqlCon.Close();
        }
    }
}
