using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private string text;
        private int len = 0;
        private string text1;
        private int len1 = 0;
        public Home(string value)
        {
            InitializeComponent();
            contas();
            text1 = label6.Text;
            label6.Text = "";
            text = label5.Text;
            label5.Text = "";
            timer1.Start();
            timer2.Stop();
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 100, 100));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 100, 100));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 100, 100));
            panel_stock.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_stock.Width, panel_stock.Height, 80, 80));
        }
        int a = 1;
        int i = 1;
        int b = 1;
        int med = 0;
        int equi = 0;
        int inf = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (len1 < text1.Length)
            {
                label6.Text = label6.Text + text1.ElementAt(len1);
                len1++;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(len < text.Length)
            {
                label5.Text = label5.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
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
                        med = myReader.GetInt32(0);
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
                        equi = myReader.GetInt32(0);
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
                        inf = myReader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlCon.Close();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            label_medicamentos.Text = a + "";
            a = a + 25;
            if (a >= med) timer3.Stop();
            if(timer3.Enabled == false) label_medicamentos.Text = Convert.ToString(med);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label_equipamentos.Text = b + "";
            b = b + 15;
            if (b >= equi) timer4.Stop();
            if (timer4.Enabled == false) label_equipamentos.Text = Convert.ToString(equi);
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            label_inflamaveis.Text = i + "";
            i = i + 15;
            if (i >= inf) timer5.Stop();
            if (timer5.Enabled == false) label_inflamaveis.Text = Convert.ToString(inf);
        }
    }
}
