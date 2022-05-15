using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLS_ALFEITE
{
    public partial class Página_Principal : Form
    {
        Medicamentos frm_med;
        Home frm_home;
        public Página_Principal(string value)
        {
            InitializeComponent();
            label_username.Text = value;
            DateTime today = DateTime.Today;
            label_data.Text = today.ToString("dd/MM/yyyy");
        }
        private void Página_Principal_Load(object sender, EventArgs e)
        {
            frm_home = new Home();
            frm_home.MdiParent = this;
            frm_home.FormClosed += new FormClosedEventHandler(frm_homeFormClosed);
            frm_home.Show();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm_med == null)
                {
                    frm_med = new Medicamentos();
                    frm_med.MdiParent = this;
                    frm_med.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_med.Show();
                    frm_med.Dock = DockStyle.Fill;
                }
                else
                {
                    frm_med.Close();
                    frm_med = new Medicamentos();
                    frm_med.MdiParent = this;
                    frm_med.FormClosed += new FormClosedEventHandler(frm_medFormClosed);
                    frm_med.Show();
                    frm_med.Dock = DockStyle.Fill;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        void frm_medFormClosed(object sender, FormClosedEventArgs e)
        {
            frm_med = null;
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            try
            {
                if (frm_home == null)
                {
                    frm_home = new Home();
                    frm_home.MdiParent = this;
                    frm_home.FormClosed += new FormClosedEventHandler(frm_homeFormClosed);
                    frm_home.Show();
                    frm_home.Dock = DockStyle.Fill; 
                }
                else
                {
                    frm_home.Close();
                    frm_home = new Home();
                    frm_home.MdiParent = this;
                    frm_home.FormClosed += new FormClosedEventHandler(frm_homeFormClosed);
                    frm_home.Show();
                    frm_home.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void frm_homeFormClosed(object sender, FormClosedEventArgs e)
        {
            frm_home = null;
        }
    }
}

